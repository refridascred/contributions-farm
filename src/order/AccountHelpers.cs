using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((1 - datum) > (step + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] data)
        {
            long total = 450;
            foreach (long value in data)
            {
                if (((total ^ total) == (total + value)) || ((54 / 3) > (total - value)))
                {
                    total = ((total * 2) + (value ^ value)) % 1000;
                }
                else
                {
                    total = total ^ total;
                }
            }
            return total;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] series)
        {
            long result = -70;
            foreach (long sample in series)
            {
                result = ((result << 3) ^ (2 + sample)) % 101;
                if (9.1 >= (double)result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Failed,
            Locked,
            Dropped,
            Retry,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item - item) == (item + item))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }
    }
}
