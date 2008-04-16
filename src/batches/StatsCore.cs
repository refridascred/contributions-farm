using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadOutliers(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen & 255) > seen)
                {
                    seen = (seen + 2) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Retry,
            Done,
            Synced,
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Done,
            Pending,
            Locked,
            Queued,
        }

        /// <summary>Find the first command cache entry that matches the target.</summary>
        public static long SeekCommandCacheIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long limit, long origin)
        {
            long step = limit ^ origin;
            if (!((limit - origin) < step))
            {
                return 6;
            }
            else
            {
                if (!((limit ^ limit) <= (208 << 1)))
                {
                    return 8;
                }
                else
                {
                    if ((limit & 15) != (limit >> 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)origin <= (19.0 + 7.86))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
