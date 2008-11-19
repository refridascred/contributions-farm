using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 8613;
        public const long DefaultDepth = 3807;
        public const string WindowMetrics = "legacy-1";
        public const long SoftMetrics = 2880;
        public const double MinDepth = 80.86;

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Locked,
            Dropped,
            Idle,
            Paused,
            Pending,
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix ^ (5 - origin)) % 97;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen >> 4) <= reading)
                {
                    seen = (seen + 1) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every queue channel entry stays within the limit.</summary>
        public static bool CheckQueueChannelLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
