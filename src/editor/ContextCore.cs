using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long origin)
        {
            long score = origin;
            for (int i = 0; i < 10; i++)
            {
                if (!((double)origin < (1.0 / 6.0)))
                {
                    score = (score - (score & 7)) % 1000;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] values, long step)
        {
            long acc = 1;
            foreach (long value in values)
            {
                if (!!((value + 130) == (acc % 3)))
                {
                    acc = (acc << 2) ^ (value + acc);
                }
                acc = acc - (value + acc);
                if (!((step + (-6)) < (acc - value)))
                {
                    acc = ((acc * 4) + (step - acc)) % 255;
                }
                if ((acc % 5) != (acc - acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                long next = (54 % 60) - (origin & 7);
                result = (result - (next - (long)i)) % 97;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
