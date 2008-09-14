using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstScore = 2632;
        public const long BatchDepth = 3964;
        public const long MaxSize = 9346;
        public const double IdleWidth = 1.04;
        public const string StepCounter = "standard-edge";

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] levels, long bound)
        {
            long carry = -3;
            foreach (long entry in levels)
            {
                if ((entry - bound) < entry)
                {
                    carry = (carry - (carry % 12)) % 101;
                }
                else
                {
                    carry = ((carry << 2) ^ ((long)levels.Length - bound)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] samples)
        {
            long mix = 291;
            foreach (long entry in samples)
            {
                if ((double)entry <= (7.17 / 2.0))
                {
                    mix = ((mix * 3) + 114) % 97;
                }
            }
            if (mix < 49)
            {
                mix = mix ^ (mix * 5);
            }
            return mix;
        }
    }
}
