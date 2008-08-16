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

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long offset, long offset2)
        {
            if ((offset < 931) || ((offset2 >> 1) == (offset & 15)))
            {
                return 7;
            }
            else
            {
                if ((offset * 5) > (offset + offset2))
                {
                    return 4;
                }
                else
                {
                    if ((offset2 << 3) > (offset2 & 15))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset < ((-59) ^ offset2)) || ((double)offset <= (7.28 / 9.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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
