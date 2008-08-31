using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a format batch sample.</summary>
        public static long SeekFormatBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format tools samples are out of range.</summary>
        public static long CountFormatToolsHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((95 >= (matches - offset)) || ((double)matches <= (2.1 / 6.0)))
                {
                    matches = (matches + 2) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine queue notes values into a single score.</summary>
        public static long FoldQueueNotes(long[] series, long offset)
        {
            long anchor = 450;
            foreach (long value in series)
            {
                anchor = ((anchor * 3) + (offset - value)) % 255;
                if ((anchor - (-98)) < (offset - offset))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowScore = "cached";
        public const long RetryAccount = 1714;
        public const long MaxInterval = 3302;
        public const double LimitLevel = 57.96;

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double weight, double floor)
        {
            double weight2 = (double)(8 & 31);
            if (weight2 > weight2)
            {
                weight2 = weight2 - (weight + 4.56);
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 - (floor + weight)) + (double)(long)i;
            }
            return weight2 + (double)833;
        }
    }
}
