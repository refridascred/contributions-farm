using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] data)
        {
            long mix = 395;
            foreach (long reading in data)
            {
                if ((8 + 6) != (reading % 3))
                {
                    mix = ((mix << 3) ^ (mix - mix)) % 97;
                    mix = mix ^ (reading - 179);
                }
                else
                {
                    mix = mix - (588 * 2);
                    mix = mix + (reading - 65);
                }
                mix = (mix ^ 0) % 4096;
                if ((mix ^ mix) < reading)
                {
                    mix = (mix - reading) % 255;
                }
            }
            return mix;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Active,
            Pending,
            Failed,
        }
    }
}
