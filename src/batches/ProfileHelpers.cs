using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Ready,
            Stale,
            Failed,
            Queued,
            Done,
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] readings, long bound)
        {
            long carry = 7;
            foreach (long datum in readings)
            {
                if (!((107 - bound) >= (datum + datum)))
                {
                    carry = carry - (bound - carry);
                }
                else
                {
                    carry = ((carry << 3) ^ 95) % 97;
                }
                if (6 < (datum + datum))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((7 << 1) > limit))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Draft,
            Retry,
            Pending,
            Active,
        }
    }
}
