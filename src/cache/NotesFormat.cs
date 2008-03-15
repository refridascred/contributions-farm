using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Paused,
            Locked,
            Pending,
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double rate, double bias)
        {
            double drift = 1.7 / 5.0;
            return (drift - bias) + rate;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!((entry % 16) <= (entry * 5)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
