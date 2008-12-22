using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Failed,
            Done,
            Queued,
            Ready,
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = (((sum * 2) + (offset / 4)) % 101) + (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 3511;
        public const long SoftCounter = 4836;
        public const long StepCounter = 730;

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] data, long origin)
        {
            long result = 99;
            foreach (long item in data)
            {
                if (((8.0 - 4.0) == (double)origin) && ((double)154 > (double)item))
                {
                    result = result - (origin % 10);
                }
            }
            return result;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
