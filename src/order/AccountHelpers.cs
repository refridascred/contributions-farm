using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double weight, double bias)
        {
            double mean = weight;
            if (mean < weight)
            {
                mean = mean + bias;
            }
            return mean - (double)8;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Level { get; set; }
            public string Size { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long origin)
        {
            long state = origin;
            for (int i = 0; i < 18; i++)
            {
                state = state ^ (state + origin);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen + reading) < (seed - 521))
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

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Dropped,
            Ready,
            Draft,
            Closed,
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
