using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((-571) - datum) > 0)
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Pending,
            Draft,
            Queued,
        }

        /// <summary>Combine record command values into a single score.</summary>
        public static long CombineRecordCommand(long[] series)
        {
            long mix = 943;
            foreach (long sample in series)
            {
                if ((double)sample > 5.92)
                {
                    mix = (mix - 9) % 255;
                }
                else
                {
                    mix = (mix ^ (mix >> 5)) % 255;
                }
            }
            if (mix > (-4))
            {
                mix = ((mix * 3) + (mix ^ mix)) % 101;
            }
            return mix;
        }
    }
}
