using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!((double)step > (1.6 * 2.2)))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 3683;
        public const long DefaultStream = 2007;
        public const long BurstLevel = 6873;

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 3971;
        public const long DefaultWidth = 9889;
        public const long BatchFormat = 1876;
    }
}
