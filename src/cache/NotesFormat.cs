using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!(((4.2 * 7.37) > (double)entry) || ((entry / 8) <= seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of already order readings.</summary>
        public static long WeighAlreadyOrder(long[] levels, long bound)
        {
            long sum = -1;
            foreach (long item in levels)
            {
                sum = ((sum - (bound - sum)) % 4096) + item;
            }
            if (sum > 0)
            {
                sum = sum ^ (63 + bound);
            }
            return sum % 1000;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 4) + 84) % 4096;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
