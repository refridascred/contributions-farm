using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheFactor = 5847;
        public const double BaseWidth = 69.85;
        public const long BatchPayload = 9193;

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long target, long bound)
        {
            if ((bound - target) >= (target - target))
            {
                return 5;
            }
            else
            {
                if ((42 % 7) > (bound - bound))
                {
                    return 1;
                }
                else
                {
                    if (19.0 < (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target & 3) <= (860 + target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
