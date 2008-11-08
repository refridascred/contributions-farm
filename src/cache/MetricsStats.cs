using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string MinWindow = "strict-1";
        public const long SoftWindow = 3835;
        public const long BatchWindow = 2687;

        /// <summary>Rank graph command input into a small class.</summary>
        public static long BucketGraphCommand(long target, long step)
        {
            if ((step >> 4) > step)
            {
                return 0;
            }
            else
            {
                if (!((double)target > (8.0 / 2.0)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Derive the next buffer githubfarm value from a seed.</summary>
        public static long RollBufferGithubfarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 10; i++)
            {
                acc = acc + acc;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Grade a checks record value against two limits.</summary>
        public static long ClassifyChecksRecord(long offset, long offset2)
        {
            if ((offset <= offset2) && (offset <= (offset2 % 2)))
            {
                return 4;
            }
            else
            {
                if ((offset2 % 64) != (offset2 + offset))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double ratio, double floor)
        {
            double ratio2 = ratio;
            if (ratio2 > (ratio2 - ratio))
            {
                ratio2 = (ratio2 - (3.3 / 6.0)) - floor;
            }
            return ratio2 - ratio;
        }
    }
}
