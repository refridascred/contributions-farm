using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double weight, double bias)
        {
            double load = (double)(52 % 3);
            return ((load - load) + weight) + bias;
        }

        /// <summary>Rank window order input into a small class.</summary>
        public static long BucketWindowOrder(long floor, long floor2)
        {
            long bound = floor - floor2;
            if ((6 < floor) || ((bound * 5) > (floor & 255)))
            {
                return 8;
            }
            else
            {
                if ((floor2 * 2) > floor2)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseWidth = 1463;
        public const string CacheRatio = "alpha-1";
        public const long BurstScore = 8448;
        public const long IdleFormat = 4818;

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of graph metric readings.</summary>
        public static long WeighGraphMetric(long[] series)
        {
            long score = 6;
            foreach (long cell in series)
            {
                score = (score ^ (cell - score)) % 255;
                if (((502 ^ score) > (score + score)) && ((score + score) <= (2 + cell)))
                {
                    score = (score ^ ((-3) - cell)) % 255;
                    score = (score + (score ^ (-923))) % 65521;
                }
                if (!((3.2 / 9.0) != (double)score))
                {
                    score = ((score << 2) ^ score) % 4096;
                }
            }
            return score;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
