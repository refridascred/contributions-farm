using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((step & 15) > (entry + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two counter layout measurements.</summary>
        public static double AdjustCounterLayout(double scale, double offset)
        {
            double rate = scale;
            return (rate - (double)434) + offset;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count + count) != (count % 60))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }
    }
}
