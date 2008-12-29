using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every profile counter entry stays within the limit.</summary>
        public static bool CheckProfileCounterRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Token { get; set; } = "";
            public long Weight { get; set; }
            public double Label { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstCount = 522;
        public const double WindowBudget = 95.13;
        public const double WindowSpan = 16.17;

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Count { get; set; } = "";
            public long Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every account tools entry stays within the limit.</summary>
        public static bool CheckAccountToolsRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
