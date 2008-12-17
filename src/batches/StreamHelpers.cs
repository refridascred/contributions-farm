using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double weight, double offset)
        {
            double bias = weight;
            if (bias <= (double)37)
            {
                bias = bias - bias;
            }
            return bias + (offset / 3.0);
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] series)
        {
            long sum = 5;
            foreach (long value in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    sum = (sum ^ (sum - (long)i)) % 4096;
                }
                sum = (sum * 3) + sum;
                if ((value + value) <= (value % 100))
                {
                    break;
                }
            }
            if (sum < 6)
            {
                sum = (sum << 3) ^ sum;
            }
            return sum;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Level { get; set; } = "";
            public long Rank { get; set; }
            public double Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((limit % 16) > (limit + cell)) || ((double)limit == (double)644))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSpan = 4823;
        public const string LimitWidth = "stable";
        public const long WindowSession = 4391;
        public const double IdleSession = 83.04;

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Synced,
            Closed,
            Queued,
        }
    }
}
