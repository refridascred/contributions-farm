using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double ratio, double bias)
        {
            double drift = bias;
            if (drift > (double)3)
            {
                drift = drift - drift;
            }
            return drift - (ratio + bias);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxContext = "staging-edge";
        public const double MinSpan = 18.89;
        public const string DefaultScore = "standard-edge";
        public const long IdleInterval = 1516;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!(((hits * 5) != (reading % 60)) || ((hits - reading) >= (hits + reading))))
                {
                    hits = (hits + 3) - step;
                }
            }
            return hits;
        }
    }
}
