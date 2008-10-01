using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate window metrics readings against a bound.</summary>
        public static bool ValidateWindowMetricsBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Offset { get; set; }
            public long Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BaseCount = 78.76;
        public const long SoftCommits = 197;
        public const string IdleCommits = "staging-v2";
        public const long RetryCommits = 8832;
        public const double DefaultCommits = 40.85;
    }
}
