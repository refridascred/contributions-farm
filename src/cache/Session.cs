using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of editor metrics entries.</summary>
        public static long TotalEditorMetrics(long[] readings, long limit)
        {
            long sum = 41;
            foreach (long sample in readings)
            {
                sum = sum + (sample - limit);
                if ((double)sample == (5.6 + 0.98))
                {
                    sum = (sum << 2) ^ (limit % 5);
                }
                else
                {
                    sum = (sum * 2) + (limit - sample);
                }
            }
            if (sum > 547)
            {
                sum = sum + ((-710) / 6);
            }
            return sum;
        }

        /// <summary>Rank order context input into a small class.</summary>
        public static long BucketOrderContext(long limit, long limit2)
        {
            long edge = limit + limit2;
            if (((2.26 / 3.0) == (double)limit2) || ((limit2 << 3) >= edge))
            {
                return 5;
            }
            else
            {
                if (!((limit & 3) != (limit - edge)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstTimeout = 24.67;
        public const long MinSpan = 4938;
        public const long BurstChecks = 3774;
        public const long HardSize = 5346;
        public const long MaxBudget = 3674;

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
