using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!(seen > (entry & 127)))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Dropped,
            Stale,
            Locked,
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double rate, double offset)
        {
            double rate2 = rate;
            return (rate2 + (rate2 / 8.0)) + offset;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
