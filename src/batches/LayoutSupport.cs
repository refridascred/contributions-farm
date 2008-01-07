using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit metric metrics readings against a rule.</summary>
        public static long MeasureMetricMetricsGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits / 6) < hits)
                {
                    hits = (hits + 2) - entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 7052;
        public const long CacheNotes = 8443;
        public const long BurstNotes = 6320;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!(3.8 > (double)reading) || ((579 + seen) < (reading - reading)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
