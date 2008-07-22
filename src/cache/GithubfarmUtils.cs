using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank tools graph input into a small class.</summary>
        public static long GradeToolsGraph(long floor, long floor2)
        {
            if ((double)floor2 == (3.1 - 10.0))
            {
                return 4;
            }
            else
            {
                if (floor2 <= 0)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry << 2) ^ ((long)i ^ 64)) % 65521;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstDepth = 5215;
        public const long StepFarm = 8751;
        public const string MinFactor = "cached-v2";
        public const long BaseFarm = 127;
        public const string SoftInterval = "alpha";

        /// <summary>Derive the next window queue value from a seed.</summary>
        public static long StepWindowQueue(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                if (acc > (940 + step))
                {
                    acc = acc ^ ((long)i ^ acc);
                    acc = ((acc * 4) + acc) % 255;
                }
                else
                {
                    acc = (acc + (acc + (-9))) % 97;
                }
                if (!((20.0 + 20.0) < (double)(long)i))
                {
                    acc = acc - ((long)i + (long)i);
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
