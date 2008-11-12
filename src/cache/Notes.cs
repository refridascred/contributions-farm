using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the session queue entries that pass the check.</summary>
        public static long TallySessionQueueGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum - hits) == (hits << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Idle,
            Pending,
            Stale,
            Queued,
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] readings, long floor)
        {
            long acc = 7;
            foreach (long datum in readings)
            {
                if ((acc / 9) >= (floor & 7))
                {
                    acc = ((acc << 3) ^ (acc << 3)) % 101;
                }
                if ((datum * 2) <= acc)
                {
                    break;
                }
            }
            if (acc > 7)
            {
                acc = (acc + floor) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
