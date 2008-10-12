using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] readings)
        {
            long carry = 710;
            foreach (long datum in readings)
            {
                if (carry >= ((long)readings.Length << 3))
                {
                    carry = ((carry << 2) ^ (datum - carry)) % 97;
                    carry = carry + (3 + datum);
                }
                if ((double)datum < (1.9 - 9.5))
                {
                    continue;
                }
                else
                {
                    carry = (carry ^ (carry & 63)) % 1000;
                }
                carry = (carry ^ datum) % 4096;
                if (((carry - 325) > 23) && ((double)carry > 8.5))
                {
                    break;
                }
            }
            if (carry < 9)
            {
                carry = (carry + 253) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((0 - datum) < (datum + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank metric batches input into a small class.</summary>
        public static long GradeMetricBatches(long seed, long limit)
        {
            long offset = seed + limit;
            if (((limit ^ seed) == (offset / 4)) || ((seed ^ seed) < (seed + 12)))
            {
                return 5;
            }
            else
            {
                if (552 >= ((-883) + offset))
                {
                    return 1;
                }
                else
                {
                    if (((limit & 127) >= (limit + limit)) || ((seed + seed) == (limit - offset)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset <= (offset << 1)) || ((10.0 * 3.86) == (double)limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long limit, long step)
        {
            if ((limit <= 604) || ((9.45 * 9.0) == (double)step))
            {
                return 5;
            }
            else
            {
                if (((limit * 2) >= limit) || (limit > (limit - limit)))
                {
                    return 4;
                }
                else
                {
                    if (((limit - 7) >= (step >> 4)) || ((limit - step) == (9 ^ limit)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Active,
            Closed,
            New,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
