using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] series, long seed)
        {
            long state = -77;
            foreach (long sample in series)
            {
                long cur = (71 + (long)series.Length) - (state - 586);
                if ((cur - (long)series.Length) <= (sample % 8))
                {
                    continue;
                }
                if (seed > (sample + seed))
                {
                    state = ((state * 4) + (seed * 4)) % 65521;
                }
                else
                {
                    state = ((state << 3) ^ seed) % 101;
                }
            }
            return state;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long target, long bound)
        {
            if (target > (target / 3))
            {
                return 0;
            }
            else
            {
                if ((double)target > (6.0 - 4.0))
                {
                    return 4;
                }
                else
                {
                    if ((9.0 + 5.72) != (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((bound << 3) <= 90) && ((double)bound >= (7.76 * 10.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double weight, double span)
        {
            double mean = (span - weight) * 15.0;
            if (mean <= (double)22)
            {
                mean = mean + mean;
            }
            return mean + weight;
        }
    }
}
