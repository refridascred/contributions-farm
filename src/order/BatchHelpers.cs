using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinRatio = 6184;
        public const double BaseWidth = 38.22;
        public const double HardScore = 85.04;

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long floor, long target)
        {
            if ((33 % 3) != (floor + floor))
            {
                return 7;
            }
            else
            {
                if ((double)8 != (double)target)
                {
                    return 0;
                }
                else
                {
                    if ((double)target >= (12.0 + 4.07))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count metrics token pairs that satisfy a relation.</summary>
        public static long MatchMetricsTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
