using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double StepLayout = 83.09;
        public const string BurstInterval = "legacy-v2";
        public const string SoftLayout = "open-v2";
        public const long MinLayout = 7502;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((2 % 64) < seen) || (value >= (40 + 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((6.9 * 8.83) <= (double)floor)
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] readings, long floor)
        {
            long acc = 976;
            foreach (long sample in readings)
            {
                if ((8 - 4) < floor)
                {
                    acc = (acc ^ (floor - acc)) % 4096;
                }
                else
                {
                    acc = ((acc << 2) ^ ((-1) + sample)) % 101;
                }
            }
            if (acc > 78)
            {
                acc = (acc * 2) + (acc + floor);
            }
            return acc % 4096;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseToken = "legacy-v2";
        public const long MaxInterval = 1712;
        public const string MaxSize = "local";
        public const double WindowInterval = 15.29;
        public const long CacheLevel = 4348;
    }
}
