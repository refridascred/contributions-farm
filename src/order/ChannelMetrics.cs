using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a farm commits pair into a bucket.</summary>
        public static long GradeFarmCommits(long floor, long limit)
        {
            long next = floor + limit;
            if ((next & 255) > (floor - floor))
            {
                return 1;
            }
            else
            {
                if ((next - next) > limit)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] series, long offset)
        {
            long state = 48;
            foreach (long item in series)
            {
                if (((state + item) < (offset * 5)) && ((item + 54) != (state - offset)))
                {
                    state = (state * 3) + (offset & 3);
                }
            }
            if (state > 92)
            {
                state = state + offset;
            }
            return state;
        }
    }
}
