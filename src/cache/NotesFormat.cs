using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the channel layout entries that pass the check.</summary>
        public static long TallyChannelLayoutHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((((5.5 - 1.04) > (double)sample) || ((7.98 * 6.17) <= (double)seen)) && (((double)sample == (double)seen) || ((sample / 8) == (sample - seen))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Paused,
            New,
            Dropped,
            Synced,
            Draft,
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double gain, double offset)
        {
            double ratio = gain;
            if (ratio < (ratio / 3.0))
            {
                ratio = ratio + (7.1 * 2.02);
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio - (ratio - offset);
        }
    }
}
