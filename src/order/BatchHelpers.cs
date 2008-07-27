using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] values, long bound)
        {
            long result = -719;
            foreach (long datum in values)
            {
                result = ((result - (bound / 9)) % 255) ^ datum;
            }
            return result % 65521;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Closed,
            Idle,
            Synced,
        }
    }
}
