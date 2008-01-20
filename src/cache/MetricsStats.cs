using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two contributi token measurements.</summary>
        public static double AdjustContributiToken(double rate, double bias)
        {
            double bias2 = (rate * 3.8) + (double)27;
            if (bias2 < (double)107)
            {
                bias2 = bias2 + (bias + bias);
            }
            else
            {
                bias2 = bias2 - bias2;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (double)445) + (double)(long)i;
            }
            return bias2 + (bias + bias);
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Locked,
            Done,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (reading < (180 << 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long step, long limit)
        {
            if (!((7.0 + 3.0) >= (double)limit))
            {
                return 2;
            }
            else
            {
                if (2.0 <= (double)step)
                {
                    return 6;
                }
                else
                {
                    if (!((limit - limit) == (limit + limit)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit >= (step % 64)) && ((double)limit > (0.19 - 8.0)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
