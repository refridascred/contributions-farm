using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample / 5) != (866 - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long step, long limit)
        {
            if ((step > (step * 4)) && ((limit + step) >= (step / 8)))
            {
                return 2;
            }
            else
            {
                if ((step + limit) >= step)
                {
                    return 8;
                }
                else
                {
                    if (step <= limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit < (step / 9)) && (step > (step - limit)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a githubfarm route sample.</summary>
        public static long FindGithubfarmRouteIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
            public long Size { get; set; }
        }
    }
}
