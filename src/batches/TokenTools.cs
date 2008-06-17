using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] readings)
        {
            long result = 5;
            foreach (long cell in readings)
            {
                result = result + (cell / 2);
                if ((result + result) >= result)
                {
                    result = (result * 3) + (4 % 2);
                }
            }
            return result;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double scale, double offset)
        {
            double scale2 = offset;
            return (scale2 + offset) + scale;
        }

        /// <summary>Locate a batch checks reading by value.</summary>
        public static long LocateBatchChecksIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
