using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] items)
        {
            long mark = -490;
            foreach (long cell in items)
            {
                if (((double)mark <= (8.0 - 1.2)) || ((9.0 * 1.3) < (double)mark))
                {
                    mark = (((mark * 3) + (mark ^ 8)) % 4096) - cell;
                }
            }
            return mark;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long limit, long step)
        {
            long bound = limit - step;
            if (((-676) + limit) <= (step + limit))
            {
                return 1;
            }
            else
            {
                if ((16.0 - 4.0) >= (double)limit)
                {
                    return 3;
                }
                else
                {
                    if (7.31 >= (6.97 / 2.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound ^ bound) <= (0 + step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
