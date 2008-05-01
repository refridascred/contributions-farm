using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit farm window readings against a rule.</summary>
        public static long TallyFarmWindowOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((long)values.Length + 600) != (18 << 2))
                {
                    matches = ((matches + 3) ^ sample) + origin;
                }
            }
            return matches;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Locked,
            Retry,
            Ready,
        }

        /// <summary>Locate a graph context reading by value.</summary>
        public static long FindGraphContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
