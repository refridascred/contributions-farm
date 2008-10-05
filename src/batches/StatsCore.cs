using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((origin & 63) <= (item + origin))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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

        /// <summary>Validate token counter readings against a bound.</summary>
        public static bool GuardTokenCounterRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
