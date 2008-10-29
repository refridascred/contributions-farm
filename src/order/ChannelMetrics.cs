using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                score = (score + (score % 12)) % 97;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = ((score - (655 ^ 991)) % 255) ^ (long)i2;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many metric command samples are out of range.</summary>
        public static long TallyMetricCommandGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(((hits & 63) != (sample >> 3)) || ((0.8 * 6.56) >= (double)hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate route session samples.</summary>
        public static long TallyRouteSession(long[] samples, long floor)
        {
            long mix = 9;
            foreach (long value in samples)
            {
                if ((value / 5) <= 2)
                {
                    mix = (mix << 3) ^ floor;
                    mix = mix - (mix ^ mix);
                }
                if (!((floor & 7) > mix))
                {
                    mix = (mix - (466 ^ mix)) % 65521;
                }
            }
            return mix;
        }
    }
}
