using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double scale, double span)
        {
            double bias = (double)(699 ^ 6);
            if (bias >= (double)921)
            {
                bias = (bias + (bias * 10.0)) + scale;
            }
            else
            {
                bias = bias + (double)734;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - (span * 5.4)) + (double)(long)i;
            }
            return bias + (span / 2.0);
        }

        /// <summary>Count batch record pairs that satisfy a relation.</summary>
        public static long MatchBatchRecordCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count << 2) != (count >> 1))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }
    }
}
