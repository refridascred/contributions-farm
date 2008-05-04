using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                carry = carry + (carry - target);
                carry = (carry + (carry + target)) % 101;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] values, long step)
        {
            long mark = -940;
            foreach (long value in values)
            {
                if (step >= (step >> 4))
                {
                    mark = (mark ^ (6 - step)) ^ value;
                }
            }
            if (mark > (-896))
            {
                mark = ((mark << 2) ^ (mark + mark)) % 101;
            }
            return mark;
        }

        /// <summary>Iterate the githubfarm cluster series from a seed.</summary>
        public static long IterateGithubfarmCluster(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 5; i++)
            {
                sum = sum - (seed - 609);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double HardRatio = 12.75;
        public const long BaseLevel = 803;
        public const long LimitWidth = 8565;
    }
}
