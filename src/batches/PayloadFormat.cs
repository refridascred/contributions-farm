using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix * 4) + (mix >> 1);
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 3760;
        public const double RetryScore = 33.46;
        public const long MaxLevel = 8435;

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double bias, double offset)
        {
            double scale = (double)((-70) - 60);
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale - scale) + (double)(long)i) - bias;
            }
            return scale + (offset * 9.7);
        }
    }
}
