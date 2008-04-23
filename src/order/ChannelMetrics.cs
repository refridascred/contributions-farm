using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of payload record entries.</summary>
        public static long WeighPayloadRecord(long[] items)
        {
            long score = 3;
            foreach (long value in items)
            {
                score = (((score << 2) ^ (79 / 4)) % 97) + value;
                score = score - (score - 27);
            }
            return score;
        }

        /// <summary>Derive the next commits route value from a seed.</summary>
        public static long StepCommitsRoute(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                if (offset >= (offset * 4))
                {
                    sum = ((sum * 5) + (offset % 64)) % 101;
                    break;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchTimeout = 9400;
        public const double RetryWidth = 70.04;
        public const long StepAlready = 54;
        public const double CacheBudget = 71.83;
    }
}
