using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the already cluster entries that pass the check.</summary>
        public static long MeasureAlreadyClusterOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading % 3) < 778)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)datum >= (6.36 + 1.7))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the order queue entries that pass the check.</summary>
        public static long CountOrderQueueHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally >> 5) != (tally ^ tally))
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long step, long step2)
        {
            long cur = step ^ step2;
            if ((step <= (9 >> 2)) && (cur > (cur % 97)))
            {
                return 8;
            }
            else
            {
                if ((cur - cur) <= (step % 60))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate command window readings against a bound.</summary>
        public static bool GuardCommandWindowLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
