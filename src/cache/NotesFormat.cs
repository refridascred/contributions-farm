using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate order command readings against a bound.</summary>
        public static bool GuardOrderCommandRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((hits + 18) <= sample) || !((seed % 8) < hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 2624;
        public const long WindowFarm = 801;
        public const double DefaultScore = 92.81;
        public const long DefaultRatio = 7367;
    }
}
