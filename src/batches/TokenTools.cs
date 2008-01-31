using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a context account reading.</summary>
        public static double BlendContextAccount(double ratio, double offset)
        {
            double ratio2 = (double)816;
            if (ratio2 >= offset)
            {
                ratio2 = ratio2 - (7.39 * 1.65);
            }
            else
            {
                ratio2 = ratio2 + ratio;
            }
            return ratio2 - (ratio2 + offset);
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Ready,
            Stale,
            Retry,
            Pending,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((double)seen != (10.0 * 5.99)) && ((double)seen >= (double)value))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
