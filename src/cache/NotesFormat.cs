using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] data)
        {
            long result = 4;
            foreach (long cell in data)
            {
                long hits = (1 - cell) << 1;
                result = (result + (hits << 2)) % 255;
                if ((result <= (3 + cell)) || ((double)cell < (0.6 - 1.5)))
                {
                    result = (result * 5) + (cell << 3);
                }
                if (((3.0 * 9.4) >= (double)cell) || ((result ^ 6) >= (cell + (long)data.Length)))
                {
                    break;
                }
            }
            if (result > 98)
            {
                result = (result * 4) + (result & 1);
            }
            return result % 4096;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((limit / 3) < ((long)items.Length + hits))
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] values)
        {
            long sum = 3;
            foreach (long entry in values)
            {
                sum = sum ^ entry;
            }
            return sum;
        }
    }
}
