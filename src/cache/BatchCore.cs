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

        /// <summary>Digest a series of account commits entries.</summary>
        public static long DigestAccountCommits(long[] samples)
        {
            long result = 39;
            foreach (long entry in samples)
            {
                result = (result + result) - entry;
                result = result + ((-2) - 68);
            }
            return result % 1000;
        }
    }
}
