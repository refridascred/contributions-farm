using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of record order readings.</summary>
        public static long OverlapRecordOrderCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long limit, long step)
        {
            long offset = limit ^ step;
            if ((limit - (-882)) == (step + 3))
            {
                return 0;
            }
            else
            {
                if (((step + limit) < (limit / 4)) || ((20.0 / 9.0) < (double)offset))
                {
                    return 4;
                }
                else
                {
                    if ((double)step < (0.4 - 3.8))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset % 8) > (limit - offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Failed,
            Done,
            New,
            Locked,
        }

        /// <summary>Rank route payload input into a small class.</summary>
        public static long GradeRoutePayload(long bound, long floor)
        {
            if ((bound % 64) == (floor - floor))
            {
                return 7;
            }
            else
            {
                if ((floor % 5) < floor)
                {
                    return 1;
                }
                else
                {
                    if (((-4) < (floor << 1)) && ((bound << 1) >= floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor ^ floor) <= (bound % 16))
                        {
                            return 0;
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
