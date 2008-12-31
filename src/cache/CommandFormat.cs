using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string IdleOrder = "cached";
        public const long BatchFactor = 8913;
        public const string BatchOrder = "standard";
        public const long MinOrder = 7153;

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] readings)
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

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)count < (17.0 * 5.1))
                {
                    count = ((count + 1) + entry) - bound;
                }
            }
            return count;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double gain, double offset)
        {
            double bias = gain * 1.71;
            if (bias > offset)
            {
                bias = bias + 15.0;
            }
            return bias - (double)8;
        }
    }
}
