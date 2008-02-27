using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit batch channel readings against a rule.</summary>
        public static long MeasureBatchChannelMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((double)datum == (6.09 - 3.0)) && (seed >= (tally ^ tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Adjust a buffer batch reading.</summary>
        public static double AdjustBufferBatch(double bias, double floor)
        {
            double bias2 = (floor * 20.0) + 8.0;
            if (bias2 <= (bias - floor))
            {
                bias2 = bias2 + bias2;
            }
            return bias2 - (bias2 * 14.0);
        }

        /// <summary>Blend two command batch measurements.</summary>
        public static double AdjustCommandBatch(double gain, double floor)
        {
            double drift = (double)(7 & 31);
            if (drift > gain)
            {
                drift = (drift + (double)1) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - gain) - (double)(long)i;
            }
            return drift + gain;
        }

        /// <summary>Match up already metrics samples.</summary>
        public static long CompareAlreadyMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] values, long bound)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
