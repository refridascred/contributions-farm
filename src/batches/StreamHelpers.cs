using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Flag { get; set; }
            public long Limit { get; set; }
            public string Level { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long target, long seed)
        {
            long lane = target ^ seed;
            if (lane <= target)
            {
                return 5;
            }
            else
            {
                if (((seed - lane) > (7 * 5)) || ((seed >> 1) >= (target << 3)))
                {
                    return 2;
                }
                else
                {
                    if ((8.5 / 9.0) > (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Draft,
            Ready,
            Done,
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long bound, long seed)
        {
            long step = bound - seed;
            if (((double)bound < 6.4) && ((bound + bound) == (seed >> 3)))
            {
                return 0;
            }
            else
            {
                if ((step << 2) <= seed)
                {
                    return 2;
                }
                else
                {
                    if (((839 << 1) != (step ^ seed)) || (7.3 > (double)bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step / 2) >= (bound / 6))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            Synced,
            Paused,
            Dropped,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!((target * 3) < reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
