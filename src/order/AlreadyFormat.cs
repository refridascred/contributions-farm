using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double bias, double floor)
        {
            double scale = floor;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale - (double)616) - (double)(long)i) - bias;
            }
            return scale + (2.44 / 9.0);
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 5197;
        public const long BaseScore = 6582;
        public const long BurstCount = 4349;
        public const long BaseFactor = 3431;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 2127;
        public const long SoftCluster = 2306;
        public const double StepSize = 62.21;
        public const long IdleCluster = 685;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] values, long origin)
        {
            long acc = 0;
            foreach (long reading in values)
            {
                acc = ((acc * 4) + origin) ^ reading;
            }
            if (acc > 31)
            {
                acc = ((acc * 3) + (acc * 2)) % 65521;
            }
            return acc % 97;
        }
    }
}
