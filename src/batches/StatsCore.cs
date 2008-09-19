using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long floor, long limit)
        {
            if (!((2.6 * 6.3) >= (double)limit))
            {
                return 2;
            }
            else
            {
                if ((3.1 + 15.0) != (double)limit)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitTimeout = 163;
        public const long BatchContributi = 1241;
        public const long LimitContributi = 259;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxSpan = 4852;
        public const double MaxBuffer = 93.94;
        public const long MinDepth = 553;

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Done,
            Active,
            Paused,
            Queued,
            Draft,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((sample ^ matches) == (sample << 3)) && ((matches + 117) == (sample ^ sample)))
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }
    }
}
