using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Check that every stream window entry stays within the limit.</summary>
        public static bool ValidateStreamWindowRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                state = (state ^ ((-3) + state)) % 65521;
                state = state - (state % 7);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long floor, long limit)
        {
            long cur = floor + limit;
            if ((cur / 3) <= cur)
            {
                return 3;
            }
            else
            {
                if ((double)limit < 3.3)
                {
                    return 1;
                }
                else
                {
                    if ((double)cur <= (13.0 * 12.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((cur < (6 << 1)) && ((limit / 7) <= limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Dropped,
            Failed,
            Synced,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportLimits(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
