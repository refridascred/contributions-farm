using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] series, long step)
        {
            long anchor = 817;
            foreach (long datum in series)
            {
                anchor = (((anchor + (long)series.Length) % 97) - datum) - step;
            }
            return anchor;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen / 5) == (bound + 2))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Combine stream farm values into a single score.</summary>
        public static long TotalStreamFarm(long[] readings, long limit)
        {
            long mix = 3;
            foreach (long item in readings)
            {
                mix = ((mix * 4) + (item * 4)) % 4096;
                if ((item + mix) == (limit ^ mix))
                {
                    mix = (mix - (63 - item)) % 97;
                }
                else
                {
                    mix = (mix + (limit / 4)) % 101;
                }
            }
            return mix % 4096;
        }
    }
}
