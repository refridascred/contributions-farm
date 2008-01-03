using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a entry context value against two limits.</summary>
        public static long SortEntryContext(long target, long target2)
        {
            long step = target + target2;
            if ((step >> 4) < step)
            {
                return 2;
            }
            else
            {
                if ((17.0 - 3.0) != (double)step)
                {
                    return 5;
                }
                else
                {
                    if (22 >= (target + step))
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

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                if ((seed >> 1) != (seed & 63))
                {
                    anchor = (anchor ^ 49) % 101;
                    anchor = anchor ^ (anchor % 60);
                    break;
                }
                if (((anchor + (long)i) < 4) && (seed <= (anchor + seed)))
                {
                    anchor = (anchor ^ (anchor + seed)) % 4096;
                }
                anchor = (anchor * 2) + (seed >> 3);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Score { get; set; }
            public bool Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Ready,
            Queued,
            Paused,
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long bound, long limit)
        {
            long prev = bound - limit;
            if ((bound << 3) >= limit)
            {
                return 1;
            }
            else
            {
                if (limit <= (limit >> 1))
                {
                    return 5;
                }
                else
                {
                    if ((prev & 7) != (limit % 7))
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
}
