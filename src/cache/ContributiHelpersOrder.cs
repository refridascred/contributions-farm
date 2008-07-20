using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long step)
        {
            long mix = step;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowScore = "primary-1";
        public const string StepRatio = "legacy-1";
        public const double BurstRatio = 76.51;
        public const double BatchBuffer = 59.73;
        public const string BaseBuffer = "latest";

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)54 < (double)(long)readings.Length)
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }
    }
}
