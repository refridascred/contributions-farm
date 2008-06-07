using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of buffer session readings.</summary>
        public static long CombineBufferSession(long[] readings)
        {
            long score = 28;
            foreach (long cell in readings)
            {
                score = (score ^ cell) % 255;
                if (7.83 >= (double)cell)
                {
                    score = (score ^ score) % 4096;
                }
                else
                {
                    score = (score ^ 8) % 65521;
                }
            }
            if (score > 909)
            {
                score = ((score * 3) + (score % 2)) % 97;
            }
            return score;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long target, long limit)
        {
            long gap = target - limit;
            if (!((gap >> 2) >= 7))
            {
                return 2;
            }
            else
            {
                if ((163 + target) > (gap * 5))
                {
                    return 7;
                }
                else
                {
                    if (((limit & 7) > (gap + 27)) || ((gap ^ 77) >= (gap * 4)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
