using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the metric format entries that pass the check.</summary>
        public static long TallyMetricFormatHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading ^ 9) == (hits >> 3))
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

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)seed < (7.04 - 3.29))
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultSize = 8488;
        public const long StepCommand = 5525;
        public const long SoftScore = 3948;

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
