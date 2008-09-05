using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 8; i++)
            {
                if (((-2) * 2) == ((long)i & 63))
                {
                    sum = (sum * 2) + (sum - limit);
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = (sum - sum) ^ (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Roll a entry already counter forward.</summary>
        public static long StepEntryAlready(long seed)
        {
            long total = seed;
            for (int i = 0; i < 13; i++)
            {
                long gap = (50 / 5) + (seed / 3);
                if (!(gap > (seed * 4)))
                {
                    continue;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((8 + 96) != (matches + entry)) || ((double)entry == (double)92))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
