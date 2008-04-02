using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the githubfarm token entries that pass the check.</summary>
        public static long CountGithubfarmTokenGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count ^ datum) <= (datum + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long step, long limit)
        {
            long span = step - limit;
            if (limit < 212)
            {
                return 2;
            }
            else
            {
                if ((span % 8) <= (limit - (-588)))
                {
                    return 3;
                }
                else
                {
                    if ((6.64 - 4.1) == (double)span)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step - limit) > (step & 127))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long limit, long limit2)
        {
            if (limit < (limit2 % 8))
            {
                return 4;
            }
            else
            {
                if ((15.0 / 9.0) < (double)limit2)
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
