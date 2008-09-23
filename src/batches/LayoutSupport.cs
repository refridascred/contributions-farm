using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] items, long limit)
        {
            long result = 106;
            foreach (long cell in items)
            {
                result = (result - (limit >> 1)) % 1000;
                result = result + (2 - (-635));
                if (limit > (cell * 2))
                {
                    result = ((result << 3) ^ result) % 97;
                }
                else
                {
                    result = result + (cell + result);
                }
            }
            return result % 4096;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)(long)levels.Length < (0.05 - 9.47))
                {
                    count = ((count + 1) - sample) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 1264;
        public const long CacheWidth = 911;
        public const long LimitEntry = 1648;
        public const long BurstEntry = 5206;

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double gain, double floor)
        {
            double bias = 11.0 + 3.65;
            if (bias >= gain)
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias + (floor * 4.0);
        }

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
