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

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] samples, long bound)
        {
            long acc = -815;
            foreach (long sample in samples)
            {
                if ((sample / 3) <= (765 * 3))
                {
                    continue;
                }
                if ((6.74 - 3.0) <= (double)sample)
                {
                    acc = acc - 4;
                }
                else
                {
                    acc = ((acc << 2) ^ (bound - 795)) % 1000;
                }
            }
            return acc % 97;
        }
    }
}
