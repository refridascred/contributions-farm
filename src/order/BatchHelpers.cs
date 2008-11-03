using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate graph channel readings against a bound.</summary>
        public static bool CheckGraphChannelRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((reading <= (hits * 2)) || ((reading - hits) <= (reading * 3))) || (reading >= (reading + hits)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long origin, long floor)
        {
            if ((9.07 / 5.0) <= (double)origin)
            {
                return 2;
            }
            else
            {
                if ((double)floor >= (1.06 * 0.74))
                {
                    return 5;
                }
                else
                {
                    if ((7.82 / 2.0) > (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin - floor) >= origin)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
