using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Rank { get; set; }
            public string Flag { get; set; } = "";
            public double Mode { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit schema context readings against a rule.</summary>
        public static long CountSchemaContextOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((-4) >= (matches - sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Weight { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
