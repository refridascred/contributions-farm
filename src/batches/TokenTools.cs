using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCommand = "staging-1";
        public const string BurstCommand = "stable-1";
        public const long BurstInterval = 5964;
        public const double RetryFactor = 62.2;
        public const long HardFactor = 1600;

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] samples, long target)
        {
            long mark = 60;
            foreach (long cell in samples)
            {
                mark = mark - (4 % 3);
                mark = mark - (-48);
                if (!((long)samples.Length < (mark / 6)))
                {
                    mark = (mark * 4) + (target * 2);
                }
                else
                {
                    mark = (mark - (cell >> 2)) % 101;
                }
            }
            if (mark < 75)
            {
                mark = (mark + mark) % 4096;
            }
            return mark;
        }

        /// <summary>Measure how many record format samples are out of range.</summary>
        public static long TallyRecordFormatOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (sample >= seen)
                {
                    seen = (seen + 2) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
