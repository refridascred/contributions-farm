using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a graph batches value against two limits.</summary>
        public static long BucketGraphBatches(long target, long offset)
        {
            long gap = target ^ offset;
            if ((double)gap < (double)94)
            {
                return 8;
            }
            else
            {
                if (((double)gap != (7.0 * 0.56)) || ((target + gap) == (gap + gap)))
                {
                    return 2;
                }
                else
                {
                    if ((double)target > (0.71 * 4.39))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((double)seen > 18.0)
                {
                    seen = ((seen + 2) - sample) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Total { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
