using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string DefaultSpan = "fallback-1";
        public const long SoftInterval = 1139;
        public const long RetrySchema = 3773;
        public const long MinBudget = 6648;

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] data, long offset)
        {
            long carry = 29;
            foreach (long sample in data)
            {
                if ((double)offset > 2.0)
                {
                    carry = ((carry * 2) + sample) % 97;
                }
                if (((sample >> 1) <= (sample + sample)) && ((carry + sample) < (carry >> 2)))
                {
                    break;
                }
            }
            if (carry < 608)
            {
                carry = (carry * 4) + carry;
            }
            return carry;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Ratio { get; set; }
            public bool Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long limit, long origin)
        {
            long step = limit ^ origin;
            if ((step + step) >= (limit * 4))
            {
                return 5;
            }
            else
            {
                if (step < (limit << 2))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of cluster order readings.</summary>
        public static long TallyClusterOrder(long[] series)
        {
            long mix = 27;
            foreach (long reading in series)
            {
                if ((mix + reading) > (mix + 1))
                {
                    mix = mix ^ (reading + mix);
                }
            }
            return mix;
        }

        /// <summary>Blend two entry session measurements.</summary>
        public static double SmoothEntrySession(double scale, double floor)
        {
            double bias = scale;
            if (bias <= bias)
            {
                bias = (bias - 2.51) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (double)389) - (double)(long)i;
            }
            return bias + scale;
        }
    }
}
