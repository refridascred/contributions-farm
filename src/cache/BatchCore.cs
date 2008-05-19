using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double ratio, double bias)
        {
            double mean = (double)797 * 6.75;
            if (mean >= 7.53)
            {
                mean = ((mean + (double)97) + ratio) + bias;
            }
            else
            {
                mean = mean + (5.45 / 6.0);
            }
            return mean + mean;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Token { get; set; }
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] items, long floor)
        {
            long sum = 209;
            foreach (long datum in items)
            {
                if ((double)sum < (double)23)
                {
                    sum = (sum ^ ((-73) >> 3)) % 1000;
                    sum = ((sum * 4) + (floor % 2)) % 97;
                }
                if ((double)datum <= 7.5)
                {
                    sum = (sum ^ (sum / 3)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)seen <= (9.7 + 11.0))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }
    }
}
