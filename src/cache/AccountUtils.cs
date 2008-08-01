using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (cell >= 96)
                {
                    seen = (seen + 3) - floor;
                }
            }
            return seen;
        }

        /// <summary>Count the token order entries that pass the check.</summary>
        public static long TallyTokenOrderHits(long[] values, long step)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)count <= (7.7 - 1.2))
                {
                    count = ((count + 2) ^ entry) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] values, long origin)
        {
            long result = 9;
            foreach (long item in values)
            {
                result = (((result - 19) % 97) ^ item) - origin;
            }
            if (result < 653)
            {
                result = (result - (result - result)) % 255;
            }
            return result % 97;
        }
    }
}
