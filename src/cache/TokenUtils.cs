using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] levels, long origin)
        {
            long acc = 448;
            foreach (long cell in levels)
            {
                if (acc <= origin)
                {
                    acc = (acc + (acc & 7)) % 65521;
                }
                if (!(acc < cell))
                {
                    acc = (acc + (acc / 9)) % 97;
                }
                else
                {
                    acc = (acc * 4) + (acc - cell);
                }
            }
            return acc;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Dropped,
            Pending,
            Active,
            Draft,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((long)i >= ((long)i ^ offset))
                {
                    total = (total ^ (offset ^ (long)i)) % 65521;
                }
                if (((double)offset < (double)894) || ((total + offset) > (offset & 7)))
                {
                    total = (total ^ (long)i) % 97;
                    total = ((total * 4) + offset) % 101;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
