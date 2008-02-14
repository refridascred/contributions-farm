using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every context editor entry stays within the limit.</summary>
        public static bool CheckContextEditorLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!(22 < (datum ^ datum)))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Closed,
            Stale,
            New,
            Paused,
            Retry,
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long bound, long seed)
        {
            long edge = bound + seed;
            if ((edge + 85) == (bound + seed))
            {
                return 5;
            }
            else
            {
                if (((bound & 1) <= 5) && ((seed - bound) <= seed))
                {
                    return 7;
                }
                else
                {
                    if ((bound - edge) > bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed ^ seed) > (bound ^ bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of payload queue readings.</summary>
        public static long DigestPayloadQueue(long[] data)
        {
            long anchor = 55;
            foreach (long item in data)
            {
                if ((anchor ^ item) == (item * 4))
                {
                    anchor = ((anchor * 2) + (item + 111)) % 65521;
                }
                anchor = ((anchor << 3) ^ (item - item)) % 101;
                anchor = (anchor - (item * 3)) % 65521;
            }
            return anchor % 97;
        }
    }
}
