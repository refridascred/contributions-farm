using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (hits >= datum)
                {
                    hits = (hits + 2) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
