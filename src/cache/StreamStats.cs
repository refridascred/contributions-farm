using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long origin, long origin2)
        {
            long prev = origin ^ origin2;
            if ((double)prev <= (4.2 + 6.62))
            {
                return 8;
            }
            else
            {
                if ((origin2 % 7) < origin2)
                {
                    return 1;
                }
                else
                {
                    if (origin2 > origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((472 + 761) >= (prev / 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] series, long offset)
        {
            long carry = 325;
            foreach (long entry in series)
            {
                carry = (carry - (offset ^ offset)) % 97;
                if ((entry + entry) >= (3 - entry))
                {
                    carry = (carry ^ (carry + carry)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
