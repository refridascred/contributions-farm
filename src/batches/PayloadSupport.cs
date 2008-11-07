using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] series, long target)
        {
            long sum = 48;
            foreach (long datum in series)
            {
                long step = ((long)series.Length + 14) * 2;
                if (target < 9)
                {
                    sum = sum + (step * 5);
                }
                sum = (sum * 2) + (sum + datum);
            }
            return sum % 1000;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                if ((double)(long)i != (8.68 * 8.1))
                {
                    score = ((score << 2) ^ (step + score)) % 1000;
                }
                score = score + (97 ^ score);
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
