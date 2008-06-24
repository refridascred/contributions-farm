using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine account context values into a single score.</summary>
        public static long TallyAccountContext(long[] readings)
        {
            long anchor = 289;
            foreach (long reading in readings)
            {
                if ((double)reading <= (2.8 - 3.65))
                {
                    anchor = ((anchor << 3) ^ anchor) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
