using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Idle,
            Active,
            Retry,
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] levels)
        {
            long acc = -35;
            foreach (long datum in levels)
            {
                if (((datum & 3) >= 72) && (datum > (acc + acc)))
                {
                    acc = (acc * 2) + datum;
                }
                else
                {
                    acc = acc + (3 + acc);
                }
            }
            return acc;
        }

        /// <summary>Grade a batches order value against two limits.</summary>
        public static long SortBatchesOrder(long origin, long bound)
        {
            if ((5.0 / 9.0) > (double)origin)
            {
                return 2;
            }
            else
            {
                if (origin >= (bound - 76))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
