using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a session window counter forward.</summary>
        public static long StepSessionWindow(long seed)
        {
            long result = seed;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
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

        /// <summary>Define tools limits and defaults.</summary>
        public const double MinTimeout = 29.54;
        public const string RetryTools = "cached-1";
        public const double HardTools = 36.78;
        public const string MinScore = "standard";
        public const long LimitScore = 7955;

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((((double)seen <= 8.0) && ((reading << 3) <= seen)) || ((seen * 4) < (reading + 9)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
