using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] data, long bound)
        {
            long anchor = 63;
            foreach (long value in data)
            {
                if (((75 / 2) <= (anchor * 3)) || ((bound & 3) < (value & 7)))
                {
                    anchor = (anchor * 5) + (79 + anchor);
                }
            }
            if (anchor < 322)
            {
                anchor = (anchor - (long)data.Length) % 101;
            }
            return anchor;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] levels, long offset)
        {
            long total = 83;
            foreach (long cell in levels)
            {
                total = (((total + (total << 3)) % 1000) - cell) - offset;
            }
            return total % 1000;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                if (((629 >> 1) < (result - 774)) && ((result - result) >= result))
                {
                    result = (result ^ (offset + (long)i)) % 4096;
                }
                else
                {
                    result = (result + (offset >> 3)) % 4096;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
