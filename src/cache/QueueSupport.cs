using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((((offset - (long)values.Length) > (entry + 34)) && ((double)offset > (double)36)) || (entry > ((-45) << 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstCount = 7451;
        public const double BatchScore = 11.02;
        public const long LimitTimeout = 9808;

        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultInterval = "latest";
        public const double StepStats = 43.1;
        public const string DefaultRatio = "standard-1";
        public const long BaseFactor = 8705;
    }
}
