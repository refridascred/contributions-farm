using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches <= (87 - 729)) && (((matches + (-90)) == (matches >> 5)) && ((matches * 4) < 74)))
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long offset, long offset2)
        {
            long cur = offset - offset2;
            if (!((6 & 1) <= (offset - offset2)))
            {
                return 5;
            }
            else
            {
                if ((offset2 << 3) == (cur * 5))
                {
                    return 0;
                }
                else
                {
                    if (offset2 >= (offset2 - offset2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double weight, double offset)
        {
            double ratio = offset;
            return ratio - weight;
        }

        /// <summary>Rank window token input into a small class.</summary>
        public static long BucketWindowToken(long seed, long origin)
        {
            if (seed > (seed / 4))
            {
                return 8;
            }
            else
            {
                if (((origin ^ origin) < seed) || (608 > (origin + 2)))
                {
                    return 1;
                }
                else
                {
                    if ((seed << 2) > (origin + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed << 1) > (origin ^ origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
