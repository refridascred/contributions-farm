using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a context contributi value against two limits.</summary>
        public static long ClassifyContextContributi(long seed, long origin)
        {
            if ((5.6 + 4.82) > (double)seed)
            {
                return 6;
            }
            else
            {
                if ((origin > (origin << 1)) || ((463 * 2) < origin))
                {
                    return 2;
                }
                else
                {
                    if ((458 - origin) > 11)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed >> 4) < (origin - origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] readings)
        {
            long anchor = 4;
            foreach (long value in readings)
            {
                anchor = anchor + (anchor << 1);
                anchor = ((anchor * 5) + (value - (long)readings.Length)) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Owner { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!(38 <= (6 + tally)))
                {
                    tally = ((tally + 2) ^ sample) + seed;
                }
            }
            return tally;
        }

        /// <summary>Adjust a layout record reading.</summary>
        public static double AdjustLayoutRecord(double weight, double span)
        {
            double mean = (span + weight) / 4.0;
            if (mean > (double)10)
            {
                mean = mean + (6.4 / 5.0);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean / 7.0)) - (double)(long)i;
            }
            return mean - (weight / 7.0);
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((91 ^ count) < datum)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
