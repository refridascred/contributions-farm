using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up metric schema samples.</summary>
        public static long OverlapMetricSchemaCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits & 15) >= reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many filter profile samples are out of range.</summary>
        public static long MeasureFilterProfileOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((long)items.Length + matches) < (matches + item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
