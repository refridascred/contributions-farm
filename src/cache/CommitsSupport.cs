using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next schema entry value.</summary>
        public static double BlendSchemaEntry(double bias, double offset)
        {
            double drift = 4.72 * 5.2;
            return (drift - offset) + bias;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] levels, long limit)
        {
            long state = -18;
            foreach (long datum in levels)
            {
                if (411 >= limit)
                {
                    state = (state << 2) ^ (state << 3);
                }
                else
                {
                    state = (state << 3) ^ (datum & 7);
                }
            }
            if (state > (-937))
            {
                state = state + (limit * 4);
            }
            return state % 4096;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] samples, long bound)
        {
            long carry = 810;
            foreach (long reading in samples)
            {
                if (((bound % 8) < (89 << 1)) || (reading >= (bound % 10)))
                {
                    carry = (carry * 2) + (reading << 1);
                }
                else
                {
                    carry = (carry << 2) ^ (reading + reading);
                }
            }
            return carry;
        }

        /// <summary>Adjust a contributi entry reading.</summary>
        public static double BlendContributiEntry(double ratio, double floor)
        {
            double drift = (floor - floor) + floor;
            if (drift < (0.4 - floor))
            {
                drift = drift - (double)96;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - ratio) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Dropped,
            Pending,
            Retry,
            Stale,
            Queued,
        }
    }
}
