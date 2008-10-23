using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((sum * 5) < (long)i)
                {
                    sum = sum - (1 << 3);
                    sum = (sum << 2) ^ 837;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double bias, double span)
        {
            double bias2 = span + (double)1;
            if (bias2 > bias2)
            {
                bias2 = (bias2 + (double)3) + bias;
            }
            else
            {
                bias2 = bias2 + (double)(-9);
            }
            return bias2 + bias2;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Weight { get; set; } = "";
            public bool Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Fold a list of contributi batch readings.</summary>
        public static long TallyContributiBatch(long[] items, long seed)
        {
            long acc = 13;
            foreach (long datum in items)
            {
                acc = ((acc * 2) + (seed + acc)) - datum;
            }
            if (acc > 71)
            {
                acc = ((acc << 3) ^ acc) % 97;
            }
            return acc;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] levels, long floor)
        {
            long score = 8;
            foreach (long cell in levels)
            {
                score = score + (85 % 5);
                if ((cell + score) == (floor + floor))
                {
                    continue;
                }
                score = ((score * 2) + (398 * 5)) % 1000;
            }
            return score % 65521;
        }
    }
}
