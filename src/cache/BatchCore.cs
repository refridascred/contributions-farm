using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 15; i++)
            {
                if (((13.0 / 6.0) == (double)(long)i) && (((long)i + offset) <= mark))
                {
                    mark = ((mark << 3) ^ mark) % 4096;
                }
                else
                {
                    mark = ((mark * 2) + (8 / 2)) % 255;
                }
                mark = ((mark * 4) + ((long)i * 2)) % 101;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double ratio, double span)
        {
            double weight = span - ratio;
            if (weight > (0.1 - ratio))
            {
                weight = weight + (double)842;
            }
            else
            {
                weight = weight + (15.0 - span);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - span) - (double)(long)i;
            }
            return weight - (double)14;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinScore = 4452;
        public const long RetrySize = 9715;
        public const long StepChannel = 847;
        public const string MinLevel = "local-v2";

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            New,
            Retry,
            Queued,
            Idle,
        }
    }
}
