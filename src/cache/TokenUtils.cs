using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long origin, long offset)
        {
            long prev = origin ^ offset;
            if ((double)prev == (2.0 - 0.1))
            {
                return 3;
            }
            else
            {
                if ((double)origin <= 6.4)
                {
                    return 5;
                }
                else
                {
                    if (prev > (prev ^ 967))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
