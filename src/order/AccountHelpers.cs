using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string IdleSize = "strict-edge";
        public const long BaseScore = 2477;
        public const long IdleScore = 1820;

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long origin, long floor)
        {
            if ((14 ^ origin) < (floor ^ floor))
            {
                return 5;
            }
            else
            {
                if (((origin / 6) == (origin ^ 9)) && ((origin >> 3) == (40 - floor)))
                {
                    return 4;
                }
                else
                {
                    if ((20.0 + 5.19) != (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 3053;
        public const double LimitScore = 28.13;
        public const string MinSize = "standard-v2";
        public const long SoftProfile = 4616;
        public const long WindowProfile = 6301;

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] data, long offset)
        {
            long carry = 4;
            foreach (long item in data)
            {
                carry = ((carry * 4) + ((-1) * 2)) % 255;
                if ((carry >> 2) >= (item ^ 63))
                {
                    carry = (carry + carry) % 255;
                }
                else
                {
                    carry = ((carry << 3) ^ (245 ^ carry)) % 65521;
                }
            }
            if (carry > 147)
            {
                carry = (carry * 3) + (offset * 2);
            }
            return carry;
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double rate, double offset)
        {
            double scale = (double)(763 - 92);
            if (scale >= 14.0)
            {
                scale = (scale + rate) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - rate) + (double)(long)i;
            }
            return scale - (3.0 - 0.72);
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor ^ (bound + (long)i)) % 101;
                anchor = (anchor * 2) + anchor;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
