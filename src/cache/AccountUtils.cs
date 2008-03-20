using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a queue cache reading.</summary>
        public static double ScaleQueueCache(double weight, double offset)
        {
            double weight2 = (double)(-600) + (weight * 7.25);
            if (weight2 < (weight * 4.0))
            {
                weight2 = (weight2 - weight2) + offset;
            }
            else
            {
                weight2 = weight2 + 6.87;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 - (weight2 / 6.0)) + (double)(long)i;
            }
            return weight2 - (weight * 9.9);
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long bound, long bound2)
        {
            if (!((double)bound != (15.0 - 19.0)))
            {
                return 6;
            }
            else
            {
                if (bound2 < (40 & 3))
                {
                    return 4;
                }
                else
                {
                    if (!((3.0 + 20.0) <= (7.3 - 5.7)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Closed,
            Done,
            Ready,
        }
    }
}
