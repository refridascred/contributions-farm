using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double bias, double offset)
        {
            double load = offset * 1.9;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + (load - load)) + (double)(long)i) - bias;
            }
            return load + (5.5 - 7.83);
        }

        /// <summary>Look up the position of a metrics schema sample.</summary>
        public static long SeekMetricsSchemaIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] items)
        {
            long total = -8;
            foreach (long reading in items)
            {
                if ((8.2 / 8.0) <= (double)reading)
                {
                    total = (total << 3) ^ (reading % 64);
                }
                else
                {
                    total = ((total * 5) + (reading - reading)) % 1000;
                    total = total - (total + total);
                }
                if ((double)reading <= (double)total)
                {
                    total = total ^ total;
                }
                if (!((4 + total) <= (total + total)))
                {
                    total = total ^ 743;
                }
            }
            if (total < 993)
            {
                total = total - (total + total);
            }
            return total;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            New,
            Dropped,
            Done,
            Closed,
            Active,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 8869;
        public const double MaxOrder = 4.83;
        public const string DefaultDepth = "stable-edge";
        public const long DefaultOrder = 6377;
        public const string HardOrder = "local-1";
    }
}
