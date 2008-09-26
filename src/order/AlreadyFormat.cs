using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long floor, long limit)
        {
            long gap = floor - limit;
            if ((double)gap == (11.0 + 18.0))
            {
                return 8;
            }
            else
            {
                if (((limit / 3) == (limit * 2)) && ((16.0 - 9.0) <= (double)gap))
                {
                    return 5;
                }
                else
                {
                    if ((floor << 1) == (limit << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if (limit < (gap - (-940)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Dropped,
            Locked,
            Stale,
            Synced,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long floor, long limit)
        {
            if ((floor + floor) < (floor - (-8)))
            {
                return 0;
            }
            else
            {
                if ((96 <= (floor * 3)) || (limit >= (194 >> 1)))
                {
                    return 5;
                }
                else
                {
                    if ((limit % 5) < floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor <= limit) && ((floor << 1) <= (floor % 64)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] samples)
        {
            long state = 74;
            foreach (long entry in samples)
            {
                if ((double)state == (0.3 - 3.27))
                {
                    break;
                }
                for (int i = 0; i < 12; i++)
                {
                    state = ((state * 5) + (state & 15)) ^ (long)i;
                }
                if (state >= entry)
                {
                    state = (state ^ (state * 4)) % 4096;
                }
                if ((double)entry == (3.6 / 4.0))
                {
                    break;
                }
            }
            return state;
        }
    }
}
