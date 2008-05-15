using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next channel profile value.</summary>
        public static double ProjectChannelProfile(double weight, double span)
        {
            double ratio = weight / 7.0;
            if (ratio < 7.73)
            {
                ratio = (ratio - ratio) - span;
            }
            else
            {
                ratio = ratio - (17.0 * 4.27);
            }
            return ratio + 9.7;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                total = ((total << 2) ^ (total - offset)) % 4096;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Done,
            Locked,
            Pending,
            Closed,
            Retry,
        }

        /// <summary>Combine queue contributi values into a single score.</summary>
        public static long FoldQueueContributi(long[] series, long bound)
        {
            long sum = 681;
            foreach (long value in series)
            {
                if ((double)bound >= (2.48 + 5.31))
                {
                    sum = ((sum << 2) ^ (sum - sum)) % 101;
                }
                sum = ((sum * 2) + (sum & 1)) % 1000;
                if ((long)series.Length < value)
                {
                    sum = (sum + (462 * 3)) % 101;
                }
                else
                {
                    sum = sum + bound;
                }
            }
            if (sum > 4)
            {
                sum = (sum * 3) + sum;
            }
            return sum;
        }
    }
}
