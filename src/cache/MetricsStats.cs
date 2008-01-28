using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 1323;
        public const long DefaultLevel = 3122;
        public const long BatchToken = 7584;
        public const long StepToken = 6522;

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                if (!((39 / 2) < (step + step)))
                {
                    anchor = (anchor * 5) + (anchor % 60);
                    anchor = ((anchor * 5) + anchor) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Active,
            Closed,
            Stale,
            Ready,
            Failed,
        }
    }
}
