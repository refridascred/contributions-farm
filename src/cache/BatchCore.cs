using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double bias, double bias2)
        {
            double load = (double)0 - (double)0;
            if (load >= load)
            {
                load = load - (double)8;
            }
            else
            {
                load = load - (double)93;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - bias2) - (double)(long)i;
            }
            return load + (load + bias);
        }

        /// <summary>Measure how many contributi order samples are out of range.</summary>
        public static long TallyContributiOrderHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value ^ value) > limit)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitProfile = "staging-v2";
        public const long IdleTimeout = 1329;
        public const string WindowScore = "strict-edge";
    }
}
