using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Token { get; set; }
            public bool Owner { get; set; }
            public double Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (count >= reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] values)
        {
            long sum = -5;
            foreach (long item in values)
            {
                sum = sum + item;
                if (39 <= (sum / 3))
                {
                    break;
                }
            }
            if (sum < 82)
            {
                sum = ((sum * 3) + (sum % 12)) % 255;
            }
            return sum;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] levels, long target)
        {
            long score = 251;
            foreach (long item in levels)
            {
                score = ((score * 5) + (item >> 2)) % 255;
                if (((item >> 2) != (score - score)) || (target < item))
                {
                    score = ((score * 2) + item) % 101;
                }
                else
                {
                    score = score ^ target;
                }
                if (((score & 255) >= (item / 6)) || ((item / 6) >= (target ^ score)))
                {
                    break;
                }
            }
            return score % 65521;
        }
    }
}
