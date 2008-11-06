using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double weight, double floor)
        {
            double bias = (weight * 7.2) - (double)61;
            if (bias >= (double)0)
            {
                bias = bias - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + weight) + (double)(long)i;
            }
            return bias - (weight / 4.0);
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((sample >= (sample + sample)) || ((offset + hits) > (hits & 127))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
