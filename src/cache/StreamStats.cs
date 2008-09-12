using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((2.0 / 5.0) == (double)tally)
                {
                    tally = ((tally + 1) ^ item) + origin;
                }
            }
            return tally;
        }

        /// <summary>Classify a filter order pair into a bucket.</summary>
        public static long ClassifyFilterOrder(long offset, long step)
        {
            long gap = offset - step;
            if ((gap / 6) > (step >> 4))
            {
                return 7;
            }
            else
            {
                if (((727 << 2) > (gap ^ 428)) || ((0 * 4) == (65 - offset)))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset != (7.0 + 6.17))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((16.0 - 4.49) != (double)offset)
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

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
