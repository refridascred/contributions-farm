using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] values, long limit)
        {
            long mark = 60;
            foreach (long reading in values)
            {
                mark = ((mark - (reading & 15)) % 97) - limit;
            }
            return mark;
        }

        /// <summary>Check that every format layout entry stays within the limit.</summary>
        public static bool CheckFormatLayoutRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Size { get; set; }
            public string Region { get; set; } = "";
            public long Owner { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Offset { get; set; }
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
