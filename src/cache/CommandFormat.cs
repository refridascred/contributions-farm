using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] readings)
        {
            long score = 393;
            foreach (long cell in readings)
            {
                double gain = (20.0 + 3.44) - (3.11 / 8.0);
                if ((double)score < gain)
                {
                    score = (score ^ cell) % 1000;
                    break;
                }
                score = (score * 5) + (cell >> 4);
            }
            return score;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Paused,
            Draft,
            Closed,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell << 3) <= count)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Owner { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
        }
    }
}
