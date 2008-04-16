using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 4; i++)
            {
                result = result ^ (offset + result);
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Adjust a cache window reading.</summary>
        public static double ScaleCacheWindow(double bias, double bias2)
        {
            double ratio = bias * 13.0;
            if (ratio >= (ratio * 8.2))
            {
                ratio = ratio + (bias * 6.1);
            }
            else
            {
                ratio = ratio + (bias2 - ratio);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (bias2 - bias2)) + (double)(long)i;
            }
            return ratio + (bias * 3.55);
        }

        /// <summary>Rank queue metrics input into a small class.</summary>
        public static long SortQueueMetrics(long target, long seed)
        {
            long offset = target + seed;
            if ((target ^ seed) <= (375 - seed))
            {
                return 6;
            }
            else
            {
                if (offset < (offset + target))
                {
                    return 0;
                }
                else
                {
                    if (!(seed < (seed - target)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)target > (6.8 / 6.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double ratio, double offset)
        {
            double mean = 9.0 + 3.0;
            if (mean < (ratio + 9.7))
            {
                mean = mean + (2.0 + 5.0);
            }
            else
            {
                mean = mean + (double)72;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - offset;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Rank { get; set; } = "";
            public long Label { get; set; }
            public double Size { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
