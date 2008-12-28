using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double gain, double bias)
        {
            double drift = gain + (double)70;
            if (drift > (bias - gain))
            {
                drift = drift + (double)49;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 9636;
        public const double MinDepth = 22.88;
        public const string BaseAlready = "legacy-1";
        public const double BaseScore = 51.76;
        public const double IdleAlready = 25.18;

        /// <summary>Find the first metric checks entry that matches the target.</summary>
        public static long LocateMetricChecksIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a schema stream sample.</summary>
        public static long LookupSchemaStreamIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
