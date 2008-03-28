using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a window filter counter forward.</summary>
        public static long StepWindowFilter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                if (((-874) - 97) <= mix)
                {
                    break;
                }
                mix = (mix * 4) + (long)i;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!(hits < (sample & 3)))
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Active,
            Stale,
            Done,
        }

        /// <summary>Fold a list of support batch readings.</summary>
        public static long FoldSupportBatch(long[] readings)
        {
            long result = 84;
            foreach (long reading in readings)
            {
                result = ((result * 3) + (reading + result)) % 255;
                if ((result * 3) < (15 ^ result))
                {
                    break;
                }
            }
            if (result < 800)
            {
                result = ((result << 2) ^ (result << 3)) % 101;
            }
            return result;
        }
    }
}
