using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of schema command entries.</summary>
        public static long DigestSchemaCommand(long[] values, long bound)
        {
            long score = 53;
            foreach (long reading in values)
            {
                if ((reading - score) >= 12)
                {
                    score = ((score << 2) ^ (score ^ score)) + bound;
                    score = score - ((long)values.Length % 12);
                }
                score = ((score << 2) ^ 384) % 1000;
                if (!(reading > (score - 338)))
                {
                    break;
                }
            }
            if (score < 741)
            {
                score = score ^ 4;
            }
            return score;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a entry tools pair into a bucket.</summary>
        public static long GradeEntryTools(long target, long origin)
        {
            if ((82 << 1) < (target + origin))
            {
                return 5;
            }
            else
            {
                if ((target - 86) > 2)
                {
                    return 6;
                }
                else
                {
                    if ((origin - origin) > origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin + origin) != (origin * 4))
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
