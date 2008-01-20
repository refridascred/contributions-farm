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

        /// <summary>Measure how many order command samples are out of range.</summary>
        public static long MeasureOrderCommandOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally >> 4) >= ((long)data.Length >> 2))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
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

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Queued,
            Stale,
            Retry,
            Failed,
            Active,
        }
    }
}
