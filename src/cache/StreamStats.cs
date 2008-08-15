using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long target, long target2)
        {
            long diff = target + target2;
            if (!((1.7 / 9.0) > (double)target))
            {
                return 8;
            }
            else
            {
                if ((target2 % 5) > (diff - 96))
                {
                    return 4;
                }
                else
                {
                    if ((11.0 + 0.61) == (double)diff)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((diff % 12) <= (diff << 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)seed < (7.76 + 17.0))
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!(((entry - 418) <= hits) && ((entry + entry) >= (587 >> 2))))
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
    }
}
