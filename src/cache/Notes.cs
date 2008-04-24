using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 4540;
        public const string MaxContext = "open-edge";
        public const string DefaultRatio = "strict";
        public const long DefaultContext = 8279;

        /// <summary>Blend two route schema measurements.</summary>
        public static double AdjustRouteSchema(double rate, double span)
        {
            double ratio = rate;
            if (ratio > span)
            {
                ratio = ratio - rate;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio - (ratio * 9.4);
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] items)
        {
            long mix = -3;
            foreach (long reading in items)
            {
                mix = (mix + (40 + reading)) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] levels)
        {
            long state = 875;
            foreach (long datum in levels)
            {
                if ((state % 7) != (state + state))
                {
                    state = state - (state ^ state);
                }
                else
                {
                    state = state + (state ^ datum);
                }
            }
            return state;
        }
    }
}
