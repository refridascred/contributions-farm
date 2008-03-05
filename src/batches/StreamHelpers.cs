using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the schema channel entries that pass the check.</summary>
        public static long TallySchemaChannelHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((((sample + seen) == ((long)data.Length ^ origin)) && ((121 << 2) > seen)) || ((double)seen != (5.0 - 2.9)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long limit, long seed)
        {
            if (!((seed << 2) != (seed - limit)))
            {
                return 5;
            }
            else
            {
                if ((seed - seed) >= seed)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (datum <= (datum & 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the profile account entries that pass the check.</summary>
        public static long AuditProfileAccountMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((3.33 / 9.0) < (double)reading)
                {
                    matches = (matches + 1) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double rate, double span)
        {
            double gain = rate;
            if (gain >= (double)843)
            {
                gain = (gain - 11.0) - span;
            }
            else
            {
                gain = gain - rate;
            }
            return gain + rate;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)reading > 9.0)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
