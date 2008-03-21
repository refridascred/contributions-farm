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

        /// <summary>Rank format graph input into a small class.</summary>
        public static long GradeFormatGraph(long offset, long target)
        {
            long next = offset ^ target;
            if (((double)35 >= (double)next) && ((double)offset == (9.0 / 3.0)))
            {
                return 5;
            }
            else
            {
                if (!((double)target >= (15.0 + 7.0)))
                {
                    return 0;
                }
                else
                {
                    return 2;
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
