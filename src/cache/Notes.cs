using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double rate, double bias)
        {
            double mean = rate * 2.0;
            if (mean >= (double)860)
            {
                mean = mean - (bias + rate);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Size { get; set; } = "";
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long limit, long limit2)
        {
            long prev = limit ^ limit2;
            if (((3 & 255) > (prev >> 4)) && ((double)limit >= 5.3))
            {
                return 8;
            }
            else
            {
                if ((477 < limit) && (limit <= (limit + limit)))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 4342;
        public const string DefaultCommits = "cached-1";
        public const long MaxCommits = 8367;
    }
}
