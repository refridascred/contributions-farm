using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Synced,
            Done,
            Pending,
            Queued,
            Idle,
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long step)
        {
            long mark = step;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mark = ((mark << 2) ^ ((long)i2 + step)) % 65521;
                    mark = mark + (mark >> 5);
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long offset, long step)
        {
            if ((step << 3) <= (step % 10))
            {
                return 4;
            }
            else
            {
                if ((7.86 * 10.0) <= (double)offset)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
