using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate cluster channel samples.</summary>
        public static long TallyClusterChannel(long[] series, long target)
        {
            long score = 122;
            foreach (long sample in series)
            {
                if (((target & 1) != (target >> 2)) || ((sample - sample) < (target - target)))
                {
                    continue;
                }
                score = (score - (3 >> 2)) % 65521;
                if ((target >= 38) || ((sample / 3) <= (3 - (-40))))
                {
                    break;
                }
            }
            if (score < 850)
            {
                score = ((score * 3) + (score + score)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Grade a command channel value against two limits.</summary>
        public static long RankCommandChannel(long target, long origin)
        {
            long bound = target - origin;
            if (((origin ^ bound) == (origin / 8)) && ((5.77 - 16.0) >= (double)bound))
            {
                return 1;
            }
            else
            {
                if (((double)target > 8.0) && ((origin + origin) <= (270 ^ origin)))
                {
                    return 4;
                }
                else
                {
                    if (target > (657 - 86))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading + seen) == (seen + reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
