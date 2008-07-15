using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((36 & 3) <= (step - matches))
                {
                    matches = (matches + 2) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Limit { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] data)
        {
            long sum = 91;
            foreach (long cell in data)
            {
                sum = (sum ^ (cell & 7)) % 1000;
                if ((double)sum <= (14.0 + 0.8))
                {
                    sum = (sum ^ (sum - sum)) % 4096;
                }
                if (cell >= sum)
                {
                    sum = (sum + (cell + cell)) % 97;
                }
                if (sum < (sum + cell))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxWidth = 9976;
        public const long StepNotes = 2484;
        public const double LimitNotes = 28.3;
        public const string RetryCount = "latest-1";

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Weight { get; set; }
            public string Count { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double SoftSize = 29.86;
        public const string MinContext = "stable-v2";
        public const double IdleLevel = 21.47;
        public const string DefaultSpan = "strict-edge";
    }
}
