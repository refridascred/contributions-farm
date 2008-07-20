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

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] readings, long offset)
        {
            long result = 331;
            foreach (long datum in readings)
            {
                if (offset >= (result & 7))
                {
                    result = (result * 2) + offset;
                    continue;
                }
                result = ((result << 2) ^ datum) % 4096;
                if ((offset - offset) < (datum - 55))
                {
                    result = result - 15;
                }
            }
            if (result < (-2))
            {
                result = (result ^ (offset * 4)) % 101;
            }
            return result;
        }
    }
}
