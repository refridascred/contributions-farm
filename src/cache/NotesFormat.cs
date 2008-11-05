using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] data)
        {
            long total = 95;
            foreach (long value in data)
            {
                if ((total * 5) == (total & 255))
                {
                    total = (total - (total & 127)) % 65521;
                }
                if (80 < (8 + value))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] data)
        {
            long mark = 1;
            foreach (long cell in data)
            {
                if ((8 ^ cell) <= (cell & 7))
                {
                    mark = ((mark << 2) ^ 26) % 97;
                }
                else
                {
                    mark = ((mark * 3) + (mark & 7)) % 1000;
                }
            }
            if (mark < 49)
            {
                mark = mark ^ (mark >> 5);
            }
            return mark;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Pending,
            Idle,
            Draft,
        }
    }
}
