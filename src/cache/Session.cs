using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Ratio { get; set; } = "";
            public bool Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit channel queue readings against a rule.</summary>
        public static long MeasureChannelQueueOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((reading % 8) > (reading / 3)) || ((count << 1) >= (86 / 9)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the filter githubfarm entries that pass the check.</summary>
        public static long CountFilterGithubfarmMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)(-178) > (1.5 - 3.0))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Level { get; set; }
            public double Score { get; set; }
            public long Total { get; set; }
        }
    }
}
