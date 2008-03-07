using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] values, long seed)
        {
            long mix = 9;
            foreach (long sample in values)
            {
                mix = ((mix ^ mix) - sample) - seed;
            }
            if (mix < 971)
            {
                mix = (mix ^ mix) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)count < (12.0 - 3.0))
                {
                    count = ((count + 3) + cell) + seed;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BatchCount = "alpha";
        public const double StepCommand = 74.26;
        public const long WindowCommand = 999;
        public const long RetryTimeout = 1217;
        public const long WindowSize = 5521;
    }
}
