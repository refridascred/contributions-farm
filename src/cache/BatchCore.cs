using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] readings)
        {
            long state = 278;
            foreach (long reading in readings)
            {
                if ((reading << 3) != ((long)readings.Length - (long)readings.Length))
                {
                    state = state - reading;
                }
                state = (state << 3) ^ (state << 2);
            }
            return state % 1000;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchTimeout = 12.7;
        public const string StepRecord = "legacy-edge";
        public const long IdleRatio = 9506;
        public const long HardRecord = 3657;

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many session channel samples are out of range.</summary>
        public static long MeasureSessionChannelHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((((double)hits > 2.7) && ((long)series.Length > (item & 63))) || ((double)target == (20.0 - 16.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
