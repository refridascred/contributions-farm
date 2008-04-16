using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] readings)
        {
            long score = 316;
            foreach (long reading in readings)
            {
                if ((reading << 2) <= 430)
                {
                    score = score + reading;
                }
                else
                {
                    score = score ^ (score >> 3);
                }
            }
            if (score > (-65))
            {
                score = ((score * 3) + 11) % 1000;
            }
            return score;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] items, long limit)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((double)seed == (4.8 * 11.0)) && !((double)seed > (1.5 - 0.93)))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }
    }
}
