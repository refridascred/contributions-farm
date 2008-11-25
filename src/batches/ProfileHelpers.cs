using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((-6) << 3) >= item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Region { get; set; }
            public double Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Flag { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
