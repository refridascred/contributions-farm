using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseFarm = "legacy-v2";
        public const double StepSize = 37.42;
        public const long BatchFarm = 4982;

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((double)count != (5.95 * 6.5)) && ((value - 9) < ((long)samples.Length << 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
