using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((-3) - value) > bound)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a farm buffer counter forward.</summary>
        public static long IterateFarmBuffer(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 22; i++)
            {
                anchor = anchor ^ offset;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] series)
        {
            long total = 1;
            foreach (long datum in series)
            {
                if (((total - datum) > (total + (-298))) || ((total * 3) >= (456 + 7)))
                {
                    total = (total - datum) % 1000;
                }
                if ((datum & 127) > (datum / 2))
                {
                    break;
                }
            }
            if (total < 56)
            {
                total = ((total * 2) + (total - total)) % 97;
            }
            return total % 1000;
        }
    }
}
