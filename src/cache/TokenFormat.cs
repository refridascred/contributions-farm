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

        /// <summary>Digest a series of window layout entries.</summary>
        public static long FoldWindowLayout(long[] values)
        {
            long result = 61;
            foreach (long value in values)
            {
                result = (result - 68) % 97;
                result = ((result << 2) ^ (value - result)) % 4096;
                if ((52 + value) <= (result & 1))
                {
                    break;
                }
            }
            if (result > 679)
            {
                result = result ^ (result % 97);
            }
            return result % 65521;
        }
    }
}
