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

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Owner { get; set; }
            public bool Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MinFormat = "staging-edge";
        public const long BatchFormat = 7024;
        public const double StepFormat = 91.24;

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] readings)
        {
            long mark = 45;
            foreach (long cell in readings)
            {
                if ((double)cell <= 3.74)
                {
                    mark = ((mark << 2) ^ (cell - cell)) % 65521;
                }
                else
                {
                    mark = (mark - ((long)readings.Length - mark)) % 101;
                }
            }
            if (mark > 1)
            {
                mark = ((mark << 2) ^ 641) % 97;
            }
            return mark;
        }

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
