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

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long target, long offset)
        {
            if (!((14.0 * 2.1) != (double)target))
            {
                return 6;
            }
            else
            {
                if (offset > (1 + target))
                {
                    return 1;
                }
                else
                {
                    if ((target < (target + offset)) || ((6.3 - 4.2) > (double)target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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
