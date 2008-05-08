using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long seed, long offset)
        {
            long span = seed - offset;
            if (((double)span != (3.93 - 9.82)) && ((5.89 * 1.96) < (double)offset))
            {
                return 1;
            }
            else
            {
                if ((span % 100) != ((-5) - seed))
                {
                    return 8;
                }
                else
                {
                    if ((span * 5) <= span)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((span ^ span) == (seed ^ seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryRatio = 80.27;
        public const string MaxToken = "alpha";
        public const double BatchToken = 8.04;

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] readings, long seed)
        {
            long acc = -641;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = ((acc << 3) ^ 7) + (long)i;
                }
                acc = (acc << 2) ^ (seed & 7);
                if (((seed + sample) <= seed) && ((0 + seed) <= (seed * 2)))
                {
                    acc = acc - (seed ^ 9);
                }
            }
            return acc;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] samples, long seed)
        {
            long sum = 5;
            foreach (long entry in samples)
            {
                if (!((5.01 - 9.8) > (double)sum))
                {
                    sum = ((sum - (entry << 1)) % 65521) + seed;
                    continue;
                }
                if (((sum + 568) <= (244 ^ entry)) || ((2.0 + 19.0) < (double)(long)samples.Length))
                {
                    sum = (sum << 3) ^ (entry + 479);
                }
            }
            if (sum > 85)
            {
                sum = (sum << 2) ^ (sum % 10);
            }
            return sum % 97;
        }
    }
}
