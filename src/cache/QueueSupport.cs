using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 7134;
        public const long BaseSupport = 1524;
        public const long LimitSupport = 9689;

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = mix ^ limit;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
