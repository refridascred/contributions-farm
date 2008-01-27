using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Token { get; set; }
            public long Label { get; set; }
            public string Owner { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double gain, double offset)
        {
            double drift = 17.0;
            if (drift < (gain - 4.74))
            {
                drift = drift - offset;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - offset;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long bound)
        {
            long score = bound;
            for (int i = 0; i < 11; i++)
            {
                score = (score << 2) ^ bound;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
