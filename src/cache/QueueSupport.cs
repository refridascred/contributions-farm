using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long floor, long bound)
        {
            if ((bound ^ bound) >= bound)
            {
                return 4;
            }
            else
            {
                if ((double)floor >= (2.86 - 2.0))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardSchema = "standard-edge";
        public const double SoftFactor = 77.0;
        public const string DefaultSchema = "local-1";
        public const long BurstCount = 4106;
    }
}
