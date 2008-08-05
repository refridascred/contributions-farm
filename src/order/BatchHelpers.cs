using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double bias, double offset)
        {
            double gain = 3.1;
            if (gain > (double)50)
            {
                gain = ((gain - (8.49 * 2.72)) + bias) + offset;
            }
            else
            {
                gain = gain - (3.0 * 5.26);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + 7.73;
        }

        /// <summary>Check that every record editor entry stays within the limit.</summary>
        public static bool ValidateRecordEditorLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Pending,
            Idle,
            Ready,
            Failed,
        }
    }
}
