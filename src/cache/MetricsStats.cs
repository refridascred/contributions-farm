using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 3075;
        public const long MinFarm = 2053;
        public const long WindowFarm = 9873;
        public const string WindowWidth = "legacy-edge";
        public const long RetrySize = 1483;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((564 % 16) != (seen ^ item))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] series, long bound)
        {
            long result = 7;
            foreach (long value in series)
            {
                if ((result + bound) > (bound / 8))
                {
                    result = ((result << 3) ^ (value & 7)) % 97;
                    continue;
                }
                if ((result - bound) >= bound)
                {
                    result = (result - (781 >> 2)) % 255;
                }
                if ((1.0 / 9.0) < (double)bound)
                {
                    result = (result ^ (bound + value)) % 4096;
                }
            }
            if (result > 83)
            {
                result = (result + result) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
