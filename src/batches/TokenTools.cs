using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 13; i++)
            {
                if (5 >= ((long)i & 3))
                {
                    mix = (mix ^ (mix ^ (long)i)) % 255;
                    mix = mix ^ mix;
                }
                if ((8.8 + 20.0) != (double)mix)
                {
                    mix = (mix ^ mix) % 97;
                }
                if ((offset + offset) == (mix + offset))
                {
                    mix = ((mix * 2) + (35 & 127)) % 97;
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Combine payload cluster values into a single score.</summary>
        public static long ScorePayloadCluster(long[] samples, long step)
        {
            long result = -10;
            foreach (long cell in samples)
            {
                result = (result - (result / 4)) % 65521;
                if ((result + cell) < (61 - result))
                {
                    result = (result * 4) + (result << 2);
                }
                else
                {
                    result = (result * 2) + (step + cell);
                }
            }
            if (result < 4)
            {
                result = result + 602;
            }
            return result;
        }
    }
}
