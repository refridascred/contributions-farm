using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long floor, long origin)
        {
            if (6 < (origin + origin))
            {
                return 0;
            }
            else
            {
                if ((floor + 0) <= (floor + origin))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double scale, double span)
        {
            double mean = (double)(82 & 15);
            if (mean > 2.0)
            {
                mean = mean - (span * 3.7);
            }
            return mean - scale;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Draft,
            Idle,
            Retry,
            Paused,
        }
    }
}
