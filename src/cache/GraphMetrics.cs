using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public double Count { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Total { get; set; }
            public bool Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((double)(long)series.Length <= (5.6 / 8.0)) || ((523 ^ count) == (count >> 4)))
                {
                    count = (count + 3) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Done,
            Closed,
            New,
            Locked,
            Paused,
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
