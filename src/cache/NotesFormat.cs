using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long seed, long seed2)
        {
            long slot = seed - seed2;
            if ((32 > (slot ^ seed)) || (((-94) & 15) == (seed2 * 2)))
            {
                return 8;
            }
            else
            {
                if ((seed + slot) <= (23 + seed))
                {
                    return 2;
                }
                else
                {
                    if ((11.0 - 8.91) <= 4.18)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] samples)
        {
            long result = 910;
            foreach (long entry in samples)
            {
                result = ((result * 2) + (entry << 3)) % 101;
                result = ((result << 2) ^ (result - result)) % 65521;
            }
            if (result < 847)
            {
                result = (result + (result - result)) % 97;
            }
            return result;
        }
    }
}
