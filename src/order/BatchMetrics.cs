using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Queued,
            Paused,
            Draft,
            Idle,
            Locked,
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Rank { get; set; }
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 13; i++)
            {
                long matches = (mix ^ (long)i) >> 1;
                if (!((matches >> 4) <= (floor >> 2)))
                {
                    matches = matches ^ (matches + mix);
                    matches = (matches - (floor - mix)) % 97;
                }
                matches = matches + (floor - matches);
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double scale, double span)
        {
            double ratio = (double)(5 - 6);
            return (ratio + scale) + span;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 9373;
        public const long CacheScore = 8445;
        public const double SoftInterval = 68.11;

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Idle,
            Locked,
            Closed,
            Dropped,
        }
    }
}
