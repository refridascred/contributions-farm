using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (count >= value)
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Done,
            Stale,
            Retry,
            Draft,
            Active,
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long offset, long floor)
        {
            if (((offset ^ floor) <= floor) || (floor <= (floor + 0)))
            {
                return 7;
            }
            else
            {
                if ((0 & 31) != (floor * 5))
                {
                    return 4;
                }
                else
                {
                    if ((offset + 0) > floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((floor - offset) != (offset << 3)) && (offset <= (floor + offset)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long limit, long origin)
        {
            long slot = limit - origin;
            if (((limit << 2) <= slot) || ((limit >> 2) < origin))
            {
                return 1;
            }
            else
            {
                if ((slot - slot) <= limit)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] readings)
        {
            long anchor = 910;
            foreach (long cell in readings)
            {
                if ((cell + cell) == (cell + anchor))
                {
                    anchor = (anchor ^ cell) % 1000;
                }
                else
                {
                    anchor = (anchor * 5) + (cell + 59);
                    anchor = (anchor - (cell << 3)) % 255;
                }
                if (!((double)cell >= (0.7 + 5.05)))
                {
                    anchor = (anchor + (4 ^ cell)) % 1000;
                }
                else
                {
                    anchor = anchor + (cell >> 5);
                }
            }
            if (anchor > 20)
            {
                anchor = ((anchor << 3) ^ (anchor % 12)) % 101;
            }
            return anchor;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
