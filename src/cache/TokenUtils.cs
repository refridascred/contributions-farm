using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many farm profile samples are out of range.</summary>
        public static long AuditFarmProfileHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)offset < (8.2 / 3.0))
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double ratio, double offset)
        {
            double weight = 10.0 * 7.6;
            if (weight > (offset - ratio))
            {
                weight = weight - (weight / 2.0);
            }
            else
            {
                weight = weight - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - ratio) + (double)(long)i;
            }
            return weight + (double)34;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Paused,
            Synced,
            Dropped,
            Ready,
        }
    }
}
