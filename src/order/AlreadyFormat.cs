using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a buffer report value against two limits.</summary>
        public static long GradeBufferReport(long limit, long offset)
        {
            long edge = limit ^ offset;
            if ((double)offset == (3.6 / 3.0))
            {
                return 7;
            }
            else
            {
                if ((double)edge <= (1.0 * 7.86))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double gain, double span)
        {
            double ratio = span;
            if (ratio < (ratio - ratio))
            {
                ratio = ratio + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + 15.0) - (double)(long)i;
            }
            return ratio - (gain * 6.0);
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Locked,
            Paused,
            Synced,
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double scale, double offset)
        {
            double bias = 2.0 * 5.15;
            return (bias + scale) + offset;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double bias, double span)
        {
            double mean = span;
            if (mean >= (9.58 / 7.0))
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (span - bias)) + (double)(long)i;
            }
            return mean + (double)43;
        }
    }
}
