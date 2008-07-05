using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long bound, long limit)
        {
            long delta = bound - limit;
            if (delta >= (limit - 367))
            {
                return 5;
            }
            else
            {
                if ((bound / 9) <= (delta * 2))
                {
                    return 8;
                }
                else
                {
                    if ((limit % 24) <= (limit ^ bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit >= (double)bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] items, long offset)
        {
            long anchor = 0;
            foreach (long cell in items)
            {
                if ((cell + 67) >= (cell * 3))
                {
                    anchor = ((anchor * 5) + (offset + 9)) % 65521;
                }
            }
            return anchor % 97;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long limit, long target)
        {
            long next = limit ^ target;
            if (((double)target == (14.0 - 0.69)) || ((89 % 3) > target))
            {
                return 8;
            }
            else
            {
                if ((((-533) - next) != (next * 4)) || ((double)next > 8.0))
                {
                    return 5;
                }
                else
                {
                    if (!(((-774) % 10) >= (limit << 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((next + 5) < (limit - 42))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up batches batch samples.</summary>
        public static long OverlapBatchesBatchCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
