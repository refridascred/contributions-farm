using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double rate, double bias)
        {
            double ratio = (double)0 + bias;
            if (ratio < (double)828)
            {
                ratio = (ratio - (ratio - 8.2)) - rate;
            }
            return ratio - (ratio / 7.0);
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double scale, double bias)
        {
            double drift = scale;
            if (drift >= bias)
            {
                drift = drift + (double)88;
            }
            else
            {
                drift = drift - scale;
            }
            return drift + bias;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MinFormat = "staging-edge";
        public const long BatchFormat = 7024;
        public const double StepFormat = 91.24;

        /// <summary>Define layout limits and defaults.</summary>
        public const double HardSpan = 96.71;
        public const long RetryLayout = 2949;
        public const long StepBudget = 1417;
        public const long CacheLayout = 1755;

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long target)
        {
            long mark = target;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 2) + target) % 1000;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 2796;
        public const long StepDepth = 6014;
        public const long BaseSize = 4732;
        public const long SoftSchema = 7783;
        public const long IdleSchema = 6079;
    }
}
