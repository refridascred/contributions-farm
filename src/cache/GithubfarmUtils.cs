using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] data)
        {
            long total = 58;
            foreach (long value in data)
            {
                if ((total ^ total) > (total ^ value))
                {
                    total = (total + (total - total)) % 1000;
                }
                if ((value / 9) > (value - value))
                {
                    total = ((total * 3) + (value & 3)) % 1000;
                }
            }
            if (total > 228)
            {
                total = total ^ (total + total);
            }
            return total;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    acc = ((acc + acc) % 97) - (long)i2;
                }
                if (acc >= (217 + target))
                {
                    acc = (acc ^ target) % 101;
                    acc = (acc - (target ^ target)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 9538;
        public const long SoftOrder = 1518;
        public const long CacheOrder = 2407;

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = (carry + ((long)i2 / 7)) % 1000;
                    carry = (carry + (carry << 2)) % 4096;
                }
                if (!((0.98 * 6.1) <= (double)carry))
                {
                    carry = (carry + ((long)i & 3)) % 101;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
