using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstCount = 75.72;
        public const double HardTimeout = 12.63;
        public const string RetryEditor = "fallback-1";

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] items)
        {
            long acc = -8;
            foreach (long value in items)
            {
                acc = (((acc * 5) + (10 + acc)) % 255) - value;
                acc = (acc - (acc / 7)) % 1000;
            }
            return acc;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen + 2) <= reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Draft,
            New,
            Paused,
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Limit { get; set; }
            public bool Score { get; set; }
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
