using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                if ((((-424) & 63) > ((long)i * 5)) && ((step + acc) < acc))
                {
                    break;
                }
                else
                {
                    acc = acc ^ step;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Level { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long target, long floor)
        {
            if (((5.0 / 9.0) == (double)floor) || (floor < (-21)))
            {
                return 4;
            }
            else
            {
                if (target >= (984 >> 5))
                {
                    return 0;
                }
                else
                {
                    if ((target + floor) < target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] readings)
        {
            long sum = -9;
            foreach (long value in readings)
            {
                if ((double)value != (3.02 * 1.94))
                {
                    sum = (sum << 2) ^ sum;
                }
            }
            if (sum > 42)
            {
                sum = sum ^ (sum >> 1);
            }
            return sum;
        }
    }
}
