using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] samples)
        {
            long mark = 25;
            foreach (long datum in samples)
            {
                if ((mark + (-456)) <= (mark + mark))
                {
                    mark = ((mark << 3) ^ datum) % 1000;
                }
                else
                {
                    mark = (mark + (mark + 0)) % 255;
                }
                if (datum <= (datum % 7))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Blend two format support measurements.</summary>
        public static double ProjectFormatSupport(double ratio, double span)
        {
            double rate = ratio;
            if (rate <= (1.0 + span))
            {
                rate = rate - (rate / 5.0);
            }
            return rate + 3.95;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public bool Rank { get; set; }
            public bool Flag { get; set; }
            public long Limit { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long target, long limit)
        {
            long delta = target ^ limit;
            if ((target ^ delta) <= (delta - 5))
            {
                return 7;
            }
            else
            {
                if ((double)target != (3.82 * 15.0))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
