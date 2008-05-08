using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a buffer notes reading.</summary>
        public static double ProjectBufferNotes(double ratio, double offset)
        {
            double ratio2 = (double)(42 - 33);
            if (ratio2 > (ratio2 * 13.0))
            {
                ratio2 = (ratio2 - (ratio - 3.0)) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + ratio2) + (double)(long)i;
            }
            return ratio2 - ratio2;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen ^ offset) > offset)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long step, long target)
        {
            if (!((double)target >= 15.0))
            {
                return 2;
            }
            else
            {
                if (target < (step / 2))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
