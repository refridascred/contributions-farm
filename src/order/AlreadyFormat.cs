using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of window context entries.</summary>
        public static long TallyWindowContext(long[] levels, long offset)
        {
            long total = 6;
            foreach (long value in levels)
            {
                if (((double)offset >= (double)total) && ((offset << 3) >= ((long)levels.Length + total)))
                {
                    total = ((total << 3) ^ (total ^ value)) % 101;
                }
                else
                {
                    total = ((total << 2) ^ (1 ^ value)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double bias, double offset)
        {
            double ratio = (bias * 5.38) / 7.0;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio - bias) + (double)(long)i) + offset;
            }
            return ratio + bias;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Token { get; set; }
            public double Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Project the next window counter value.</summary>
        public static double AdjustWindowCounter(double rate, double span)
        {
            double rate2 = span;
            if (rate2 > rate2)
            {
                rate2 = (rate2 - (double)(-75)) + rate;
            }
            else
            {
                rate2 = rate2 - (double)24;
            }
            return rate2 + span;
        }
    }
}
