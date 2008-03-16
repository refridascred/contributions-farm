using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double scale, double floor)
        {
            double rate = (double)8 + scale;
            if (rate > floor)
            {
                rate = rate + (double)945;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (double)167) + (double)(long)i;
            }
            return rate + (rate - rate);
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] series)
        {
            long carry = 649;
            foreach (long item in series)
            {
                if ((item ^ item) >= (carry + item))
                {
                    carry = ((carry * 4) + (carry + item)) % 255;
                }
                if ((item > (item >> 1)) && (carry > (carry - carry)))
                {
                    break;
                }
            }
            if (carry > 7)
            {
                carry = carry ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Draft,
            Dropped,
            Ready,
            Locked,
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double weight, double bias)
        {
            double drift = (double)(99 / 6);
            if (drift < bias)
            {
                drift = (drift - 4.1) + weight;
            }
            return drift - bias;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Total { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
