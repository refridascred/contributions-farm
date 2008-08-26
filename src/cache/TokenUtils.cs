using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] data, long seed)
        {
            long result = 3;
            foreach (long entry in data)
            {
                result = ((result - seed) % 97) ^ entry;
            }
            if (result > 15)
            {
                result = (result << 3) ^ (1 / 9);
            }
            return result % 65521;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long limit, long limit2)
        {
            if (limit2 >= 6)
            {
                return 5;
            }
            else
            {
                if ((double)limit <= (4.07 + 14.0))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Stale,
            Closed,
            Queued,
        }
    }
}
