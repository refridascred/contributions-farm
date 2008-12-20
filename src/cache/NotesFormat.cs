using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Ready,
            Idle,
            Failed,
            Draft,
            Closed,
        }

        /// <summary>Grade a token support value against two limits.</summary>
        public static long SortTokenSupport(long offset, long step)
        {
            if ((offset / 3) == (step * 5))
            {
                return 7;
            }
            else
            {
                if (offset >= (5 / 5))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double ratio, double bias)
        {
            double ratio2 = (double)2 + 2.3;
            if (ratio2 <= (ratio2 / 4.0))
            {
                ratio2 = ((ratio2 + ratio2) - ratio) - bias;
            }
            return ratio2 - 4.2;
        }
    }
}
