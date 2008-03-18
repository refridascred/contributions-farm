using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long seed, long target)
        {
            long edge = seed + target;
            if (target < seed)
            {
                return 1;
            }
            else
            {
                if ((double)target != (7.8 + 4.66))
                {
                    return 4;
                }
                else
                {
                    if ((edge ^ edge) <= (62 ^ seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target & 15) > (seed & 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell + (-756)) <= cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a farm profile sample.</summary>
        public static long FindFarmProfileIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit profile record readings against a rule.</summary>
        public static long AuditProfileRecordGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value - 395) < value)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
