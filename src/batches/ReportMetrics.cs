using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                long step = (mix << 2) / 9;
                step = (step - (740 / 8)) % 4096;
                if ((long)i < (step + (long)i))
                {
                    break;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Paused,
            Synced,
            Idle,
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            New,
            Draft,
            Stale,
            Synced,
            Dropped,
        }
    }
}
