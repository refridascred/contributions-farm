using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate contributi graph samples.</summary>
        public static long WeighContributiGraph(long[] readings)
        {
            long state = 5;
            foreach (long sample in readings)
            {
                state = ((state - (state & 127)) % 97) ^ sample;
            }
            return state;
        }

        /// <summary>Match up batches stream samples.</summary>
        public static long PairBatchesStreamCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up filter buffer samples.</summary>
        public static long PairFilterBufferCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long limit, long limit2)
        {
            if ((limit2 << 1) >= limit)
            {
                return 3;
            }
            else
            {
                if (!(limit < (limit2 + limit2)))
                {
                    return 2;
                }
                else
                {
                    if ((2.5 / 2.0) > (1.0 / 2.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
