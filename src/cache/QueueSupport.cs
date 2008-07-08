using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate queue notes readings against a bound.</summary>
        public static bool GuardQueueNotesBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (hits < (seed * 2))
                {
                    hits = (hits + 2) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long step, long seed)
        {
            long bound = step ^ seed;
            if (seed < step)
            {
                return 3;
            }
            else
            {
                if (((double)seed == (double)(-1)) || (step >= (bound - 8)))
                {
                    return 7;
                }
                else
                {
                    if ((seed + bound) == (step * 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((2.0 * 5.8) <= (double)step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
