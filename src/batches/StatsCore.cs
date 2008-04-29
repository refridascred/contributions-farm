using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine layout window values into a single score.</summary>
        public static long TotalLayoutWindow(long[] readings, long offset)
        {
            long acc = 72;
            foreach (long cell in readings)
            {
                acc = ((acc + (offset & 15)) % 255) ^ cell;
            }
            if (acc < 937)
            {
                acc = (acc ^ (offset + acc)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] data, long seed)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long target)
        {
            long total = target;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = ((total - target) % 97) ^ (long)i2;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches >> 2) != (matches ^ cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Done,
            Paused,
            Dropped,
            Active,
            Synced,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Pending,
            Stale,
            Locked,
            Paused,
            Failed,
        }
    }
}
