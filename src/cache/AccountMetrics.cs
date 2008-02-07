using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 3) + ((-46) ^ mark)) % 255;
                mark = mark ^ (mark + mark);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] readings)
        {
            long acc = 174;
            foreach (long reading in readings)
            {
                acc = acc ^ (acc % 100);
                if ((double)reading != (double)acc)
                {
                    acc = acc - (acc + reading);
                }
                else
                {
                    acc = (acc - (acc ^ reading)) % 65521;
                }
            }
            if (acc > 42)
            {
                acc = acc + (acc % 60);
            }
            return acc;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long offset)
        {
            long total = offset;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = ((total - 396) % 65521) - (long)i2;
                }
                total = (total + (total % 60)) % 255;
                if (((total % 97) >= 0) || ((offset * 3) <= 1))
                {
                    total = (total * 5) + (offset ^ offset);
                    total = (total ^ (offset + offset)) % 4096;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
