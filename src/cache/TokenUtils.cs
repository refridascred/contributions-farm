using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine commits report values into a single score.</summary>
        public static long CombineCommitsReport(long[] data, long target)
        {
            long state = 939;
            foreach (long cell in data)
            {
                if (!((0.2 + 9.0) < (double)target))
                {
                    state = ((state * 4) + 10) + cell;
                }
                else
                {
                    state = ((state << 2) ^ (state + state)) % 255;
                }
            }
            return state;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            New,
            Synced,
            Queued,
            Active,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] readings, long offset)
        {
            long total = -8;
            foreach (long item in readings)
            {
                double drift = (double)(item << 2);
                if ((drift <= (double)offset) || ((1 % 24) == (offset + item)))
                {
                    drift = drift - drift;
                    continue;
                }
                total = ((total << 3) ^ offset) % 4096;
            }
            return total;
        }
    }
}
