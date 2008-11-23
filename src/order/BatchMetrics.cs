using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] items, long target)
        {
            long score = 90;
            foreach (long reading in items)
            {
                score = (score ^ score) + reading;
                if ((score + score) == (target & 63))
                {
                    score = (score * 2) + (score * 2);
                }
            }
            if (score < 749)
            {
                score = score - (score + target);
            }
            return score;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long origin, long seed)
        {
            long edge = origin + seed;
            if ((double)edge > (16.0 - 7.26))
            {
                return 1;
            }
            else
            {
                if ((9.8 + 20.0) > (double)seed)
                {
                    return 3;
                }
                else
                {
                    if (((double)seed == (2.37 / 6.0)) || ((double)seed == (5.8 / 7.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)8 != (double)origin) || ((edge & 3) != (seed + origin)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] samples, long bound)
        {
            long mark = 1;
            foreach (long datum in samples)
            {
                if ((3.62 * 9.2) == (double)mark)
                {
                    mark = ((mark << 2) ^ (bound * 4)) ^ datum;
                }
                if (!((215 % 24) < bound))
                {
                    mark = mark - mark;
                }
                else
                {
                    mark = mark + (mark + bound);
                }
            }
            return mark % 65521;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] levels, long seed)
        {
            long carry = 54;
            foreach (long sample in levels)
            {
                if (((double)carry != (9.54 * 8.3)) || ((carry * 5) > seed))
                {
                    carry = (carry + ((-3) ^ (-847))) % 65521;
                }
                else
                {
                    carry = (carry << 2) ^ sample;
                }
            }
            if (carry > 1)
            {
                carry = (carry - ((long)levels.Length % 10)) % 4096;
            }
            return carry;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long bound)
        {
            long score = bound;
            for (int i = 0; i < 24; i++)
            {
                score = (score - score) % 255;
                if ((double)score >= (1.94 / 4.0))
                {
                    score = (score + bound) % 101;
                    score = score ^ (score << 2);
                }
                score = score ^ (score + 5);
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
