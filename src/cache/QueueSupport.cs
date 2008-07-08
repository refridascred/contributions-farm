using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((datum + seen) == (datum ^ seen)) && !((double)datum <= 9.0))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
