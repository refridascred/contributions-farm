using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Count { get; set; }
            public double Ratio { get; set; }
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Region { get; set; } = "";
            public double Count { get; set; }
            public double Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                if (((step + 5) >= (step * 5)) && ((3.8 - 15.0) == (double)result))
                {
                    result = (result - step) % 65521;
                    result = (result + (step + result)) % 97;
                    continue;
                }
                result = result ^ 35;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleFactor = 18.62;
        public const double IdleStats = 85.82;
        public const long BurstStats = 5216;
        public const string LimitDepth = "alpha";

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Locked,
            Retry,
            Failed,
            Draft,
            Active,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (value < (seen & 127))
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }
    }
}
