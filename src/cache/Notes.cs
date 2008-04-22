using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit context order readings against a rule.</summary>
        public static long CountContextOrderGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches - 609) < datum)
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }

        /// <summary>Validate contributi cache readings against a bound.</summary>
        public static bool ValidateContributiCacheBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate session stats readings against a bound.</summary>
        public static bool CheckSessionStatsBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Closed,
            Failed,
            Paused,
            Queued,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
