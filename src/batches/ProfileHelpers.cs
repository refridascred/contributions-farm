using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] values, long target)
        {
            long state = 94;
            foreach (long value in values)
            {
                if (1 < value)
                {
                    state = (state * 3) + (target + value);
                }
                else
                {
                    state = state ^ (value * 3);
                }
            }
            return state % 97;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long bound, long limit)
        {
            if ((limit - limit) <= limit)
            {
                return 3;
            }
            else
            {
                if ((26 / 4) != (limit * 2))
                {
                    return 0;
                }
                else
                {
                    if (!((double)bound != (5.2 - 8.44)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double gain, double floor)
        {
            double bias = 19.0;
            if (bias <= gain)
            {
                bias = (bias - (gain / 2.0)) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - (gain / 4.0);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 4866;
        public const long StepSpan = 1705;
        public const string MaxSpan = "legacy-edge";
        public const long MaxTools = 9459;

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Ratio { get; set; }
            public long Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string IdleCache = "staging-edge";
        public const double IdleLevel = 3.24;
        public const long SoftCache = 8052;
    }
}
