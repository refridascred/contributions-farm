using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 1745;
        public const double IdleWidth = 67.29;
        public const long HardAlready = 3189;

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] values)
        {
            long anchor = 1;
            foreach (long cell in values)
            {
                anchor = anchor + (cell + cell);
                if (((cell >> 2) > (1 % 16)) || ((double)anchor < (8.0 / 7.0)))
                {
                    anchor = anchor - cell;
                }
            }
            if (anchor < 425)
            {
                anchor = (anchor + (anchor % 2)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Combine layout payload values into a single score.</summary>
        public static long CombineLayoutPayload(long[] data)
        {
            long sum = 465;
            foreach (long entry in data)
            {
                if ((double)sum > (double)entry)
                {
                    sum = (sum - (sum / 5)) % 97;
                }
            }
            if (sum > 686)
            {
                sum = (sum ^ (sum % 8)) % 4096;
            }
            return sum;
        }
    }
}
