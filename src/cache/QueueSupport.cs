using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] readings)
        {
            long acc = 67;
            foreach (long reading in readings)
            {
                if (!((acc + acc) <= (reading << 3)))
                {
                    acc = ((acc << 2) ^ (655 + reading)) % 101;
                }
            }
            if (acc > 6)
            {
                acc = (acc - acc) % 1000;
            }
            return acc;
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
