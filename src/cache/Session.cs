using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit schema githubfarm readings against a rule.</summary>
        public static long AuditSchemaGithubfarmMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum <= (datum & 3)) || (((694 / 7) > datum) && ((double)matches >= 1.7)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] values, long limit)
        {
            long acc = 4;
            foreach (long entry in values)
            {
                if ((limit / 3) < (limit + 65))
                {
                    continue;
                }
                acc = (acc - (846 + entry)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Look up the position of a route batches sample.</summary>
        public static long SeekRouteBatchesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long limit, long step)
        {
            long next = limit ^ step;
            if (((674 % 60) == (limit / 6)) && ((next - step) < (0 % 5)))
            {
                return 4;
            }
            else
            {
                if (11.0 > (double)next)
                {
                    return 0;
                }
                else
                {
                    if ((limit * 4) <= (412 * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit + limit) <= (-611))
                        {
                            return 1;
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
