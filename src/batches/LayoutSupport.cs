using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double bias, double floor)
        {
            double bias2 = (7.93 * 6.3) + (7.22 / 6.0);
            if (bias2 <= (bias - floor))
            {
                bias2 = bias2 + floor;
            }
            else
            {
                bias2 = bias2 + (bias2 / 9.0);
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - floor) + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((double)origin <= 4.9)
                {
                    carry = carry ^ ((-317) + origin);
                    carry = (carry ^ (carry / 6)) % 97;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
