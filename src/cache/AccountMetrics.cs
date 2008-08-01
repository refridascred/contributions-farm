using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long seed, long limit)
        {
            if (limit < (seed - seed))
            {
                return 1;
            }
            else
            {
                if ((-44) >= (limit + limit))
                {
                    return 0;
                }
                else
                {
                    if (!((limit ^ limit) == (69 / 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit + seed) > (limit + limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Weight { get; set; }
            public bool Token { get; set; }
            public double Ratio { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] samples, long offset)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (1.6 <= (double)sample)
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Ready,
            Retry,
            Paused,
            Pending,
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double rate, double offset)
        {
            double scale = offset + (rate - offset);
            if (scale <= rate)
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale + 1.5;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - 2.3;
        }
    }
}
