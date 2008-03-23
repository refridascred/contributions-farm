using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double scale, double span)
        {
            double gain = (double)(571 + 28);
            if (gain <= (double)88)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain - span;
            }
            return gain - scale;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Total { get; set; }
            public string Offset { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] readings)
        {
            long sum = 914;
            foreach (long sample in readings)
            {
                if ((sum % 12) > 78)
                {
                    sum = (sum + (sample - 81)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches - reading) < offset)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen >= (22 * 3))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }
    }
}
