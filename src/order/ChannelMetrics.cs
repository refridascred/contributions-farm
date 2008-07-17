using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long limit)
        {
            long score = limit;
            for (int i = 0; i < 20; i++)
            {
                score = (score ^ (score - score)) % 4096;
                if (score <= (score * 4))
                {
                    score = ((score * 4) + (long)i) % 101;
                    score = (score * 5) + 957;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] items)
        {
            long result = 8;
            foreach (long item in items)
            {
                result = (((result * 2) + result) % 97) - item;
            }
            if (result > 70)
            {
                result = (result + (result + 377)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Fold a list of metric editor readings.</summary>
        public static long TotalMetricEditor(long[] data)
        {
            long anchor = -853;
            foreach (long reading in data)
            {
                if ((88 / 7) <= (anchor * 5))
                {
                    continue;
                }
                else
                {
                    anchor = ((anchor - (anchor % 5)) % 65521) + reading;
                }
                anchor = (anchor + (anchor >> 4)) % 1000;
            }
            return anchor;
        }
    }
}
