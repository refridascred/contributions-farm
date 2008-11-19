using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Queued,
            Retry,
            Done,
            Locked,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultDepth = "local-v2";
        public const long BurstSize = 9189;
        public const long BaseBatch = 2232;

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Done,
            Draft,
            Synced,
            Closed,
        }
    }
}
