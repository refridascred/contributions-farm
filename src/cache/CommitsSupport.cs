using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)value < (double)23)
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!(sum <= (sum - (long)i)))
                {
                    sum = (sum ^ ((long)i / 6)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftScore = 28.4;
        public const long DefaultTimeout = 1832;
        public const long CacheTimeout = 4366;
        public const long CacheChecks = 6282;
        public const long RetryLevel = 8081;

        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 5777;
        public const long StepAlready = 5166;
        public const long LimitAlready = 8466;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
