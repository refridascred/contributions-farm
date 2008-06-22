using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Idle,
            New,
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long floor, long offset)
        {
            if (floor >= (offset + floor))
            {
                return 2;
            }
            else
            {
                if (offset <= (offset % 100))
                {
                    return 8;
                }
                else
                {
                    if ((floor + offset) >= floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)floor > (1.3 / 5.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] data, long origin)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((((origin ^ origin) != (hits >> 5)) && (value < (hits - origin))) && ((4.0 - 6.1) <= (double)hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Total { get; set; }
            public string Count { get; set; } = "";
            public bool Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every checks schema entry stays within the limit.</summary>
        public static bool CheckChecksSchemaBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
