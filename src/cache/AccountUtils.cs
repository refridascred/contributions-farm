using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up schema profile samples.</summary>
        public static long MatchSchemaProfileCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank editor schema input into a small class.</summary>
        public static long BucketEditorSchema(long floor, long seed)
        {
            long edge = floor ^ seed;
            if (!((floor / 6) >= floor))
            {
                return 4;
            }
            else
            {
                if (!((3 << 3) < edge))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Retry,
            Ready,
            Draft,
        }
    }
}
