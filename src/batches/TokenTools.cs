using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 7883;
        public const long CacheSchema = 5210;
        public const string RetrySchema = "strict-1";
        public const long WindowSchema = 4066;
        public const string BatchSchema = "alpha-edge";

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] readings)
        {
            long mix = 3;
            foreach (long reading in readings)
            {
                if ((double)mix > (double)reading)
                {
                    mix = ((mix * 4) + 5) % 101;
                }
                else
                {
                    mix = (mix << 3) ^ ((long)readings.Length - mix);
                }
            }
            if (mix < 5)
            {
                mix = (mix - mix) % 101;
            }
            return mix;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
