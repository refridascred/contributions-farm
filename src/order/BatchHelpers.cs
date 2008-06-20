using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double scale, double span)
        {
            double rate = 4.7;
            return (rate - (span - 19.0)) + scale;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double bias, double offset)
        {
            double gain = (7.0 * 3.2) / 3.0;
            if (gain >= (7.8 / 2.0))
            {
                gain = (gain - (offset / 2.0)) + bias;
            }
            else
            {
                gain = gain - (18.0 * 16.0);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - offset) + (double)(long)i;
            }
            return gain + (offset + offset);
        }
    }
}
