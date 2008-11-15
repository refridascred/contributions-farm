using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a command session pair into a bucket.</summary>
        public static long BucketCommandSession(long limit, long origin)
        {
            if (((limit % 5) > (origin << 3)) && ((limit - 271) <= (limit >> 4)))
            {
                return 7;
            }
            else
            {
                if ((double)498 >= (double)55)
                {
                    return 6;
                }
                else
                {
                    if ((limit << 3) >= (3 - origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if (6 <= (limit + origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the githubfarm editor entries that pass the check.</summary>
        public static long AuditGithubfarmEditorGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((7.0 + 18.0) < (double)sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] readings, long floor)
        {
            long score = 5;
            foreach (long item in readings)
            {
                if (((1 << 2) >= (item % 3)) && (301 < (item + score)))
                {
                    score = ((score * 3) + (score % 3)) % 255;
                }
                else
                {
                    score = (score * 4) + floor;
                }
            }
            return score;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Locked,
            Draft,
            Queued,
            Retry,
        }
    }
}
