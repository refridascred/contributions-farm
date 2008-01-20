using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long floor, long offset)
        {
            long step = floor ^ offset;
            if (floor < (227 & 255))
            {
                return 5;
            }
            else
            {
                if ((offset & 15) >= (offset / 7))
                {
                    return 4;
                }
                else
                {
                    if (step >= (50 - step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((floor / 6) == (offset << 3)) || (step < (step / 5)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Count { get; set; }
            public long Flag { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 587;
        public const long WindowScore = 3142;
        public const long MinBudget = 7353;

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate cache farm samples.</summary>
        public static long WeighCacheFarm(long[] items)
        {
            long score = 486;
            foreach (long cell in items)
            {
                if ((13.0 + 0.3) != (double)cell)
                {
                    score = score + (3 << 2);
                }
            }
            return score % 4096;
        }
    }
}
