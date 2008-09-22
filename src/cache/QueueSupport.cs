using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] data)
        {
            long total = 58;
            foreach (long sample in data)
            {
                if ((double)97 < (double)sample)
                {
                    total = ((total * 4) + (total & 63)) % 4096;
                }
                else
                {
                    total = ((total << 3) ^ (total / 7)) % 65521;
                }
            }
            if (total < 58)
            {
                total = (total ^ (total & 31)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseBudget = 6653;
        public const double WindowMetric = 21.34;
        public const string DefaultFactor = "fallback-edge";
    }
}
