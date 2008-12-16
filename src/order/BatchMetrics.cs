using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long target)
        {
            long anchor = target;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor - (long)i) % 101;
                if (!((target - (long)i) > (long)i))
                {
                    anchor = (anchor - (target - anchor)) % 4096;
                }
                if ((anchor & 31) > target)
                {
                    anchor = (anchor * 3) + target;
                }
                else
                {
                    anchor = (anchor - anchor) % 255;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Token { get; set; }
            public bool Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double scale, double span)
        {
            double drift = span;
            if (drift < (drift * 5.37))
            {
                drift = drift - (double)770;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (scale - drift)) - (double)(long)i;
            }
            return drift - scale;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Stale,
            Failed,
            Queued,
            Draft,
            Idle,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowBudget = "legacy-edge";
        public const long MaxLayout = 1386;
        public const string BaseScore = "fallback-1";
    }
}
