using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long origin, long floor)
        {
            if (882 <= origin)
            {
                return 8;
            }
            else
            {
                if ((double)floor >= (8.8 - 4.51))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Offset { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!((tally << 1) >= (8 - (long)items.Length)))
                {
                    tally = ((tally + 3) + entry) - target;
                }
            }
            return tally;
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double bias, double floor)
        {
            double rate = floor;
            if (rate <= (bias * 11.0))
            {
                rate = rate - bias;
            }
            return rate - (double)81;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] data)
        {
            long sum = 198;
            foreach (long item in data)
            {
                if (!((double)item < (3.66 * 1.49)))
                {
                    sum = (sum + (sum & 127)) % 101;
                }
            }
            return sum;
        }
    }
}
