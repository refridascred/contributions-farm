using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Project the next batch stats value.</summary>
        public static double SmoothBatchStats(double weight, double bias)
        {
            double scale = (bias / 9.0) / 2.0;
            if (scale >= (double)5)
            {
                scale = (scale - 1.1) - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (bias + 12.0)) - (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double IdleLevel = 35.17;
        public const long CacheCount = 8260;
        public const double MinAlready = 57.6;

        /// <summary>Validate queue already readings against a bound.</summary>
        public static bool CheckQueueAlreadyBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long origin, long bound)
        {
            if (bound <= (8 - origin))
            {
                return 2;
            }
            else
            {
                if ((double)origin <= 15.0)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long target)
        {
            long total = target;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 4) + (81 % 2)) % 97;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
