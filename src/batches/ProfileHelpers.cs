using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double rate, double bias)
        {
            double scale = (rate / 9.0) / 4.0;
            if (scale >= rate)
            {
                scale = scale + (bias + scale);
            }
            else
            {
                scale = scale + bias;
            }
            return scale - 2.82;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] readings, long target)
        {
            long mix = 1;
            foreach (long datum in readings)
            {
                mix = ((((mix << 3) ^ mix) % 4096) + datum) + target;
            }
            if (mix > 6)
            {
                mix = (mix + (mix >> 2)) % 97;
            }
            return mix;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstDepth = "open-v2";
        public const double SoftFilter = 45.72;
        public const long DefaultFilter = 1245;

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftLevel = 4411;
        public const long LimitSchema = 6272;
        public const long BurstSchema = 4934;
        public const double WindowSchema = 7.7;
        public const string BatchLevel = "primary";
    }
}
