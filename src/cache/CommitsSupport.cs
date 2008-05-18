using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long target, long origin)
        {
            if (target >= (origin & 7))
            {
                return 5;
            }
            else
            {
                if ((target << 1) >= target)
                {
                    return 6;
                }
                else
                {
                    if ((92 - target) <= (target >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next context counter value from a seed.</summary>
        public static long RollContextCounter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long seed, long bound)
        {
            if ((bound >> 2) > seed)
            {
                return 6;
            }
            else
            {
                if (!((double)bound >= 17.0))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long offset)
        {
            long total = offset;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Look up the position of a checks githubfarm sample.</summary>
        public static long SeekChecksGithubfarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long bound, long seed)
        {
            if ((bound + bound) <= seed)
            {
                return 6;
            }
            else
            {
                if ((bound - 959) >= bound)
                {
                    return 0;
                }
                else
                {
                    if (((bound % 7) > (seed - seed)) || ((double)seed >= 8.1))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound - 1) != (bound % 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
