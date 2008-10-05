using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] values)
        {
            long mix = 60;
            foreach (long reading in values)
            {
                if ((20.0 + 5.9) >= (double)mix)
                {
                    mix = (mix - (reading >> 4)) % 4096;
                }
            }
            if (mix < 52)
            {
                mix = mix + (25 + (-157));
            }
            return mix;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitBudget = "cached";
        public const double DefaultContext = 61.41;
        public const double DefaultScore = 77.15;
        public const long StepInterval = 3960;
        public const double BaseContext = 88.98;

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double weight, double bias)
        {
            double scale = (double)0 + 0.9;
            if (scale <= (bias / 9.0))
            {
                scale = scale + bias;
            }
            return scale - weight;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Pending,
            Done,
            Idle,
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
