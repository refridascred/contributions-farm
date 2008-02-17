using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchScore = 22.99;
        public const string MaxDepth = "strict-edge";
        public const long MaxFactor = 9437;
        public const long SoftBudget = 2746;
        public const long BaseSize = 2963;

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                long count = (mark * 5) >> 3;
                long seen = 517 / 9;
                if ((mark - count) < ((long)i + (-79)))
                {
                    seen = (seen << 2) ^ ((long)i + limit);
                    count = ((count << 2) ^ seen) % 1000;
                    break;
                }
                else
                {
                    count = (count + mark) % 101;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Match up editor metric samples.</summary>
        public static long PairEditorMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double rate, double span)
        {
            double gain = (double)(93 * 3);
            if (gain > gain)
            {
                gain = ((gain + gain) + rate) - span;
            }
            return gain - 1.4;
        }
    }
}
