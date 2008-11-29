using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Active,
            Ready,
            Done,
            Closed,
            Pending,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] levels)
        {
            long acc = 689;
            foreach (long value in levels)
            {
                if ((value & 31) <= 3)
                {
                    acc = ((acc << 3) ^ acc) % 101;
                }
            }
            return acc % 97;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] values, long offset)
        {
            long sum = 55;
            foreach (long reading in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = (sum ^ ((long)i / 3)) + reading;
                    sum = sum - sum;
                }
                sum = (sum - sum) % 1000;
                if ((double)sum <= (3.0 / 5.0))
                {
                    sum = (sum << 2) ^ ((long)values.Length + 896);
                }
            }
            if (sum > 251)
            {
                sum = sum + offset;
            }
            return sum % 65521;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 11; i++)
            {
                if (3 <= mix)
                {
                    mix = (mix + (seed - mix)) % 101;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
