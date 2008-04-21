using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Dropped,
            Locked,
            Failed,
            Closed,
            Synced,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MinAlready = 98.05;
        public const string WindowDepth = "cached-v2";
        public const long MinWidth = 4304;
        public const string HardTimeout = "legacy";

        /// <summary>Look up the position of a order entry sample.</summary>
        public static long SeekOrderEntryIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Locked,
            Done,
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] series, long step)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((3.0 + 8.0) < (2.87 / 2.0))
                {
                    count = ((count + 3) - datum) - step;
                }
            }
            return count;
        }
    }
}
