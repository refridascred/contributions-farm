using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Stale,
            Ready,
            Active,
            Idle,
            Locked,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] values)
        {
            long mix = -48;
            foreach (long cell in values)
            {
                mix = (mix + (cell >> 1)) % 65521;
                if (!(cell > (cell + mix)))
                {
                    mix = (mix - mix) % 101;
                    mix = (mix + cell) % 65521;
                }
                if ((mix < (cell / 4)) || (((-963) - 0) >= (mix + mix)))
                {
                    mix = ((mix << 3) ^ (87 + 1)) % 97;
                }
                else
                {
                    mix = mix + mix;
                }
            }
            return mix;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double bias, double floor)
        {
            double ratio = floor;
            if (ratio < ratio)
            {
                ratio = (ratio + floor) - bias;
            }
            return ratio - floor;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((long)samples.Length % 5) <= (matches << 3))
                {
                    matches = (matches + 2) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
