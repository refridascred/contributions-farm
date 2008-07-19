using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 2886;
        public const double CacheFactor = 84.41;
        public const double SoftFactor = 25.47;
        public const long StepCluster = 2497;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((527 & 63) >= cell)
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }
    }
}
