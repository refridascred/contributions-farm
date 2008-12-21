using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long bound, long seed)
        {
            long slot = bound ^ seed;
            if (((slot + slot) >= (bound << 1)) && ((double)seed < (double)0))
            {
                return 7;
            }
            else
            {
                if (((bound + 31) < (bound << 1)) || ((double)seed > (5.0 * 15.0)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Ready,
            New,
            Idle,
            Stale,
            Synced,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] readings, long limit)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (limit >= (5 + count))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Fold a list of entry command readings.</summary>
        public static long DigestEntryCommand(long[] series)
        {
            long anchor = 18;
            foreach (long entry in series)
            {
                anchor = (anchor + (entry + anchor)) % 101;
                if ((7 % 24) != (entry >> 2))
                {
                    anchor = (anchor << 3) ^ (entry % 3);
                }
                if ((entry + 0) >= anchor)
                {
                    anchor = (anchor - (anchor >> 5)) % 1000;
                }
            }
            if (anchor < 450)
            {
                anchor = (anchor + anchor) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell & 1) > (cell % 3))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
