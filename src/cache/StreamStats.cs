using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long bound, long limit)
        {
            long bound2 = bound ^ limit;
            if (908 >= (8 - bound))
            {
                return 3;
            }
            else
            {
                if (!((17.0 / 9.0) > (double)limit))
                {
                    return 7;
                }
                else
                {
                    if ((bound2 - 13) > limit)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 22; i++)
            {
                if (carry >= (floor / 2))
                {
                    carry = (carry * 2) + (carry & 7);
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] data, long origin)
        {
            long carry = 720;
            foreach (long entry in data)
            {
                carry = (carry - (origin & 63)) ^ entry;
                if ((83 % 12) <= (carry - 560))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
