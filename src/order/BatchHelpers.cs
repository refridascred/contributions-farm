using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 9951;
        public const long HardRatio = 7130;
        public const double IdleFarm = 7.48;
        public const string SoftFarm = "open-edge";

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Active,
            Ready,
            Dropped,
        }
    }
}
