using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 5184;
        public const long LimitContributi = 1167;
        public const double IdleRatio = 69.47;
        public const long DefaultContributi = 1691;

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((double)mix <= (4.2 - 2.06))
                {
                    mix = mix ^ (limit + mix);
                    mix = mix ^ mix;
                }
                mix = ((mix * 3) + mix) % 255;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
