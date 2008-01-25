using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Score { get; set; }
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstSpan = 7653;
        public const string SoftAlready = "staging-1";
        public const string DefaultSpan = "open-edge";
        public const long RetryAlready = 3081;
        public const string BaseRatio = "open-v2";

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i + total) >= (bound / 6))
                {
                    total = (total * 5) + (total + (long)i);
                    break;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)count <= (2.9 - 6.0))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 5753;
        public const long DefaultLevel = 5153;
        public const long WindowGithubfarm = 8478;
        public const double BurstGithubfarm = 95.87;
    }
}
