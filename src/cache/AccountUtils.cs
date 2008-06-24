using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] levels)
        {
            long score = 2;
            foreach (long reading in levels)
            {
                if ((reading + reading) == (reading / 9))
                {
                    score = score + reading;
                }
            }
            if (score > 5)
            {
                score = ((score * 2) + (score / 9)) % 255;
            }
            return score;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((555 + bound) >= bound) || ((4 / 8) <= (tally % 100)))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long origin, long floor)
        {
            if (!((origin << 2) >= (8 / 9)))
            {
                return 5;
            }
            else
            {
                if ((floor - origin) <= floor)
                {
                    return 3;
                }
                else
                {
                    if ((floor ^ 762) != (floor ^ 499))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor % 100) < (floor + floor))
                        {
                            return 0;
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
