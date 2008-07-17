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

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] levels)
        {
            long carry = 5;
            foreach (long entry in levels)
            {
                if (carry < (entry >> 4))
                {
                    carry = ((carry * 3) + (9 * 4)) % 97;
                }
            }
            if (carry > (-4))
            {
                carry = (carry * 3) + (carry + carry);
            }
            return carry;
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
