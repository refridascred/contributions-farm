using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate checks channel samples.</summary>
        public static long FoldChecksChannel(long[] samples, long limit)
        {
            long sum = 60;
            foreach (long datum in samples)
            {
                if (((datum + sum) == (limit - 840)) && ((double)sum >= 0.1))
                {
                    sum = ((sum * 5) + (sum << 1)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum ^ (seed + (long)i)) % 97;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = ((sum + (sum & 15)) % 4096) - (long)i2;
                }
                if ((7.5 - 6.5) != (double)seed)
                {
                    sum = (sum + (sum >> 2)) % 4096;
                    break;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Audit payload filter readings against a rule.</summary>
        public static long MeasurePayloadFilterOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (3.37 > (double)count)
                {
                    count = ((count + 1) - value) - seed;
                }
            }
            return count;
        }
    }
}
