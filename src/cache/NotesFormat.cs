using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long HardSize = 847;
        public const double MaxBatch = 32.55;
        public const long DefaultBatch = 2287;
        public const long LimitDepth = 6282;

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] readings)
        {
            long mark = 93;
            foreach (long datum in readings)
            {
                if ((16.0 * 2.4) <= (double)mark)
                {
                    mark = ((mark + (164 << 2)) % 4096) ^ datum;
                }
                else
                {
                    mark = (mark + (mark + 465)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long origin, long target)
        {
            long diff = origin ^ target;
            if (diff <= 8)
            {
                return 3;
            }
            else
            {
                if ((diff * 2) != (275 >> 4))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
