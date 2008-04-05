using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Region { get; set; }
            public string Mode { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Audit buffer editor readings against a rule.</summary>
        public static long AuditBufferEditorHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry + 1) > hits)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = total - total;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 1829;
        public const long MinInterval = 5892;
        public const double CacheProfile = 47.09;

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Limit { get; set; }
            public double Owner { get; set; }
            public string Flag { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                result = (result ^ result) % 101;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
