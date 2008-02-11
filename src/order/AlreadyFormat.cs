using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long origin, long target)
        {
            if (!(origin > (target << 3)))
            {
                return 5;
            }
            else
            {
                if (((target & 15) != (664 >> 3)) || (target <= (origin + origin)))
                {
                    return 6;
                }
                else
                {
                    if ((origin + origin) == (709 - origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally - item) > (tally + tally))
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long bound, long seed)
        {
            long edge = bound - seed;
            if (((seed % 3) > (554 ^ seed)) || ((double)seed < (1.97 + 2.27)))
            {
                return 6;
            }
            else
            {
                if ((seed ^ edge) != (bound ^ edge))
                {
                    return 7;
                }
                else
                {
                    if ((bound - bound) <= (5 - edge))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Queued,
            Closed,
            Active,
            Paused,
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double scale, double bias)
        {
            double drift = (scale / 6.0) - scale;
            if (drift < (scale / 9.0))
            {
                drift = drift - (drift + bias);
            }
            return drift + scale;
        }
    }
}
