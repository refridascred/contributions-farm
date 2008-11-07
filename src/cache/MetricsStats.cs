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

        /// <summary>Measure how many route notes samples are out of range.</summary>
        public static long AuditRouteNotesHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count / 4) > (item << 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long target)
        {
            long acc = target;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (((acc * 2) + (target % 7)) % 97) ^ (long)i2;
                    acc = (acc << 2) ^ (acc >> 1);
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
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
