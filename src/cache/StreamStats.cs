using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count counter batches pairs that satisfy a relation.</summary>
        public static long MatchCounterBatchesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchLevel = 6687;
        public const string BaseBuffer = "strict-1";
        public const long SoftBudget = 6723;
        public const long BurstBuffer = 7670;

        /// <summary>Check that every editor cluster entry stays within the limit.</summary>
        public static bool CheckEditorClusterLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double gain, double span)
        {
            double ratio = span;
            if (ratio > gain)
            {
                ratio = ratio + (ratio / 8.0);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + gain) - (double)(long)i;
            }
            return ratio + gain;
        }
    }
}
