using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long offset, long origin)
        {
            if ((offset ^ offset) <= offset)
            {
                return 3;
            }
            else
            {
                if (((double)offset != (3.0 * 4.11)) && (offset < (offset & 7)))
                {
                    return 4;
                }
                else
                {
                    if ((origin + 1) > (1 & 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] data, long limit)
        {
            long sum = 1;
            foreach (long datum in data)
            {
                if ((77 * 5) >= datum)
                {
                    sum = ((sum - (datum / 3)) % 97) - limit;
                }
                else
                {
                    sum = (sum - datum) % 255;
                }
                sum = (sum + datum) % 97;
            }
            if (sum > 7)
            {
                sum = sum - (sum % 100);
            }
            return sum;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count + seed) <= 27)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
