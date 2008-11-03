using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 3500;
        public const long BatchFactor = 9790;
        public const double RetrySupport = 42.13;

        /// <summary>Measure how many cache token samples are out of range.</summary>
        public static long MeasureCacheTokenMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((-8) ^ 610) <= (datum * 4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Match up batches batch samples.</summary>
        public static long OverlapBatchesBatchCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
