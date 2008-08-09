using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Draft,
            Active,
            Locked,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((7 / 8) >= ((long)levels.Length * 3))
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double ratio, double bias)
        {
            double load = (ratio + 6.47) - (ratio - 9.55);
            if (load < load)
            {
                load = load + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load - (double)40;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double rate, double bias)
        {
            double weight = (double)(1 ^ (-30));
            if (weight >= bias)
            {
                weight = (weight + (1.0 / 6.0)) - rate;
            }
            return weight + (bias / 6.0);
        }
    }
}
