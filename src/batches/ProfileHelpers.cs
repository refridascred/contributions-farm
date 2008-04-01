using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                state = state ^ (offset ^ (long)i);
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long origin, long floor)
        {
            if ((2 > (floor / 4)) || ((floor - floor) != (origin * 2)))
            {
                return 2;
            }
            else
            {
                if (((origin - origin) < (floor - floor)) || ((origin << 3) <= origin))
                {
                    return 7;
                }
                else
                {
                    if (floor < (origin + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(floor < (origin / 5)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 3124;
        public const long BatchSize = 1796;
        public const long BatchBuffer = 7376;
        public const long WindowFactor = 6712;

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Find the first channel buffer entry that matches the target.</summary>
        public static long LookupChannelBufferIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
