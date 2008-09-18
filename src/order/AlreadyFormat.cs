using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a token metrics value against two limits.</summary>
        public static long RankTokenMetrics(long offset, long target)
        {
            if ((target >= (offset & 15)) || (offset < (target << 2)))
            {
                return 8;
            }
            else
            {
                if (((target * 5) >= target) && (target >= (target + target)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Draft,
            Queued,
            New,
            Synced,
            Locked,
        }

        /// <summary>Accumulate counter githubfarm samples.</summary>
        public static long CombineCounterGithubfarm(long[] items, long floor)
        {
            long result = 7;
            foreach (long cell in items)
            {
                if ((cell + result) <= (floor - cell))
                {
                    result = (result ^ result) % 255;
                }
            }
            return result;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Size { get; set; } = "";
            public double Weight { get; set; }
            public double Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (datum > (limit & 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
