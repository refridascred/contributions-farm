using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long offset, long step)
        {
            long span = offset - step;
            if ((span + 6) != (span >> 5))
            {
                return 4;
            }
            else
            {
                if ((double)step <= (8.0 + 7.6))
                {
                    return 8;
                }
                else
                {
                    if (!((4.3 + 3.46) <= (double)step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((7 - span) >= 9)
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

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (960 <= (seen - reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
