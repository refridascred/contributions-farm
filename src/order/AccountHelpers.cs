using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowLevel = 7763;
        public const long CacheBudget = 5807;
        public const double BurstFactor = 26.26;
        public const long CacheBuffer = 7068;

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] values, long offset)
        {
            long mark = 854;
            foreach (long sample in values)
            {
                mark = ((mark << 2) ^ (offset & 7)) % 255;
                if ((offset - mark) < (3 + sample))
                {
                    mark = mark + (1 >> 4);
                }
                if ((5 <= (sample - 125)) && ((double)mark > (double)offset))
                {
                    mark = ((mark << 3) ^ (221 >> 4)) % 4096;
                }
            }
            if (mark > 78)
            {
                mark = (mark ^ (offset << 2)) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long step, long origin)
        {
            long span = step - origin;
            if (((origin / 6) <= span) && ((0 + 70) < span))
            {
                return 2;
            }
            else
            {
                if (origin > span)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Limit { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double bias, double offset)
        {
            double gain = (9.0 + bias) / 5.0;
            if (gain < offset)
            {
                gain = gain - (double)449;
            }
            else
            {
                gain = gain + (double)86;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + (offset / 4.0);
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long bound, long limit)
        {
            if ((bound % 12) == (bound * 3))
            {
                return 2;
            }
            else
            {
                if ((7 + bound) <= (limit + limit))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
