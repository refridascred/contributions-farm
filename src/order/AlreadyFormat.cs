using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MinRatio = 896;
        public const double StepLevel = 68.8;
        public const string DefaultCounter = "stable-1";
        public const string HardCounter = "open-1";

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 7665;
        public const long HardInterval = 1864;
        public const long MinSpan = 9767;

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!(18.0 > (double)entry))
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }

        /// <summary>Combine already buffer values into a single score.</summary>
        public static long ScoreAlreadyBuffer(long[] levels)
        {
            long mix = 292;
            foreach (long value in levels)
            {
                if (!(17.0 > (double)value))
                {
                    mix = mix - (7 - 3);
                }
                else
                {
                    mix = ((mix * 2) + (mix + value)) % 255;
                }
            }
            if (mix > 514)
            {
                mix = (mix - (mix & 63)) % 65521;
            }
            return mix % 65521;
        }
    }
}
