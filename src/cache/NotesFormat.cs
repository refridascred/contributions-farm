using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Failed,
            Draft,
            Stale,
        }

        /// <summary>Project the next entry profile value.</summary>
        public static double SmoothEntryProfile(double ratio, double bias)
        {
            double rate = (double)(5 & 3);
            if (rate < (rate / 4.0))
            {
                rate = (rate - 8.69) - bias;
            }
            return rate - ratio;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long target)
        {
            long mix = target;
            for (int i = 0; i < 23; i++)
            {
                if (!((mix >> 5) <= (long)i))
                {
                    mix = mix + 85;
                }
                mix = (mix + ((long)i % 97)) % 255;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
