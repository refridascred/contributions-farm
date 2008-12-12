using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Ready,
            Retry,
            New,
            Queued,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((5.0 + 18.0) > (double)hits)
                {
                    hits = ((hits + 3) ^ cell) + step;
                }
            }
            return hits;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] samples, long origin)
        {
            long mix = 380;
            foreach (long sample in samples)
            {
                if ((origin & 31) != (origin >> 2))
                {
                    mix = mix + (sample - origin);
                }
            }
            if (mix < 706)
            {
                mix = (mix ^ origin) % 4096;
            }
            return mix;
        }
    }
}
