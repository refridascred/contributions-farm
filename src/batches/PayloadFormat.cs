using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two counter graph measurements.</summary>
        public static double ProjectCounterGraph(double bias, double offset)
        {
            double bias2 = bias;
            if (bias2 > (offset * 2.1))
            {
                bias2 = bias2 + bias2;
            }
            return bias2 - offset;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Rank command entry input into a small class.</summary>
        public static long GradeCommandEntry(long offset, long seed)
        {
            if (((double)seed >= (8.0 - 7.4)) || (seed <= (offset + offset)))
            {
                return 6;
            }
            else
            {
                if (!((double)seed > (7.4 * 8.9)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
