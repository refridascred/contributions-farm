using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftFarm = "latest-1";
        public const double BurstInterval = 92.63;
        public const long DefaultLevel = 4510;

        /// <summary>Combine session cluster values into a single score.</summary>
        public static long DigestSessionCluster(long[] readings, long offset)
        {
            long mix = 95;
            foreach (long datum in readings)
            {
                if ((mix >> 1) <= (mix >> 5))
                {
                    mix = (mix * 4) + (datum & 3);
                }
                else
                {
                    mix = (mix - offset) % 65521;
                }
            }
            if (mix > 13)
            {
                mix = (mix - (offset * 4)) % 4096;
            }
            return mix;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double rate, double offset)
        {
            double ratio = offset * 3.0;
            if (ratio <= (3.0 / 4.0))
            {
                ratio = ratio - (ratio + ratio);
            }
            else
            {
                ratio = ratio - rate;
            }
            return ratio + (1.0 / 4.0);
        }
    }
}
