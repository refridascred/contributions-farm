using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Total { get; set; } = "";
            public long Token { get; set; }
            public string Rank { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] readings)
        {
            long acc = 127;
            foreach (long sample in readings)
            {
                if (!((1.0 * 13.0) == (double)sample))
                {
                    acc = ((acc << 3) ^ (acc % 60)) % 255;
                }
                else
                {
                    acc = (acc + (acc * 3)) % 101;
                }
            }
            if (acc > 39)
            {
                acc = (acc + acc) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((matches - offset) >= sample) || !((matches << 3) > (matches & 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Score { get; set; }
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Closed,
            Active,
            New,
        }
    }
}
