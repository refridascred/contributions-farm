using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next payload order value.</summary>
        public static double AdjustPayloadOrder(double gain, double floor)
        {
            double weight = gain * 5.51;
            return (weight - (double)(-5)) + floor;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long seed, long origin)
        {
            if ((double)origin < (double)452)
            {
                return 6;
            }
            else
            {
                if ((double)seed < (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double ratio, double floor)
        {
            double ratio2 = ratio + (double)681;
            if (ratio2 <= (ratio + ratio))
            {
                ratio2 = ratio2 - floor;
            }
            return ratio2 - (ratio / 5.0);
        }
    }
}
