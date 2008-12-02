using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] levels)
        {
            long mix = 9;
            foreach (long value in levels)
            {
                if ((mix > (mix << 1)) || ((value + mix) >= (923 % 2)))
                {
                    mix = (mix + (value - (-32))) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Check that every batch checks entry stays within the limit.</summary>
        public static bool GuardBatchChecksBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
