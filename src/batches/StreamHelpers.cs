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

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Fold a list of counter graph readings.</summary>
        public static long ScoreCounterGraph(long[] samples)
        {
            long acc = 215;
            foreach (long cell in samples)
            {
                acc = (acc + ((-495) >> 4)) + cell;
            }
            if (acc > 2)
            {
                acc = (acc + acc) % 255;
            }
            return acc;
        }
    }
}
