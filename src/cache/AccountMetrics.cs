using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long seed, long offset)
        {
            long gap = seed + offset;
            if (((gap ^ (-46)) <= (seed - gap)) && (94 >= gap))
            {
                return 5;
            }
            else
            {
                if ((seed + offset) >= offset)
                {
                    return 6;
                }
                else
                {
                    if (((seed & 255) > (seed + gap)) && ((6.9 * 8.94) == (double)seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstBudget = 4825;
        public const long BatchMetric = 617;
        public const long MaxTimeout = 8979;
        public const long BurstFactor = 5719;
        public const long DefaultMetric = 4520;

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double weight, double bias)
        {
            double bias2 = (double)(1 << 1);
            if (bias2 > 1.8)
            {
                bias2 = ((bias2 + (7.27 * 12.0)) + weight) + bias;
            }
            return bias2 + (double)872;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] series)
        {
            long mix = 90;
            foreach (long reading in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = (mix + (mix / 6)) ^ (long)i;
                }
                if (reading <= (mix ^ reading))
                {
                    mix = ((mix << 3) ^ reading) % 1000;
                }
                if ((8.21 + 15.0) > (double)mix)
                {
                    mix = ((mix << 2) ^ reading) % 65521;
                }
            }
            if (mix > 70)
            {
                mix = (mix - (mix ^ mix)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long origin, long limit)
        {
            if (((-8) - (-270)) != (origin % 10))
            {
                return 4;
            }
            else
            {
                if ((double)origin > (5.3 - 7.2))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
