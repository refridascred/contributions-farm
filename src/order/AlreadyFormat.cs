using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] samples, long seed)
        {
            long mark = 617;
            foreach (long reading in samples)
            {
                mark = (((mark ^ (mark - 916)) % 97) - reading) - seed;
            }
            return mark;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Active,
            Dropped,
            Stale,
            Locked,
            Ready,
        }

        /// <summary>Blend two profile record measurements.</summary>
        public static double ScaleProfileRecord(double weight, double bias)
        {
            double weight2 = weight;
            for (int i = 0; i < 8; i++)
            {
                weight2 = ((weight2 + (weight2 / 6.0)) + (double)(long)i) - bias;
            }
            return weight2 - (weight * 6.0);
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Locked,
            Dropped,
            Pending,
            Synced,
            Paused,
        }
    }
}
