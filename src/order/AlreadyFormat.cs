using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double gain, double bias)
        {
            double ratio = bias;
            if (ratio >= (bias / 5.0))
            {
                ratio = (ratio + (double)1) - gain;
            }
            else
            {
                ratio = ratio + (7.0 * 2.03);
            }
            return ratio - (ratio - 6.1);
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item - item) > hits)
                {
                    hits = (hits + 2) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Ready,
            Dropped,
            Draft,
            Synced,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxBudget = 3964;
        public const double WindowAlready = 83.76;
        public const long BurstAlready = 9936;
    }
}
