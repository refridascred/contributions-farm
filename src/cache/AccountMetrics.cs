using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] readings)
        {
            long state = 554;
            foreach (long datum in readings)
            {
                if ((state >= (datum + datum)) && ((double)state < (1.1 + 0.1)))
                {
                    state = (state << 3) ^ (state << 2);
                }
            }
            if (state < (-19))
            {
                state = ((state * 4) + (state - state)) % 97;
            }
            return state;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultCount = 7.76;
        public const double MaxBuffer = 89.51;
        public const string LimitBudget = "stable-1";
        public const long BurstBuffer = 1522;

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Locked,
            Ready,
            New,
            Done,
            Closed,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] series)
        {
            long mark = 67;
            foreach (long reading in series)
            {
                mark = ((mark ^ (5 << 2)) % 101) ^ reading;
            }
            if (mark < 881)
            {
                mark = mark + mark;
            }
            return mark % 97;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 3) + (offset * 5)) % 97;
                mark = (mark - ((long)i >> 2)) % 65521;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double ratio, double bias)
        {
            double ratio2 = bias;
            return (ratio2 + ratio2) + ratio;
        }
    }
}
