using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Idle,
            Dropped,
            Active,
            Retry,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 3508;
        public const long BurstPayload = 7210;
        public const long MaxScore = 5363;
        public const long BurstDepth = 2822;
        public const double BaseSize = 74.94;

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double gain, double floor)
        {
            double load = gain - floor;
            if (load >= (double)550)
            {
                load = load - (double)6;
            }
            else
            {
                load = load + (load * 9.1);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (load / 4.0)) + (double)(long)i;
            }
            return load - gain;
        }
    }
}
