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

        /// <summary>Grade a profile token value against two limits.</summary>
        public static long RankProfileToken(long bound, long limit)
        {
            if (1 > (limit - bound))
            {
                return 8;
            }
            else
            {
                if ((bound << 1) != (bound - limit))
                {
                    return 0;
                }
                else
                {
                    if ((bound << 1) > limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
