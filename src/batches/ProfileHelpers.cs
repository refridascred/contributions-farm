using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (item <= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string StepTools = "legacy-edge";
        public const long StepDepth = 8086;
        public const string IdleWidth = "stable-edge";

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of checks format readings.</summary>
        public static long CombineChecksFormat(long[] series)
        {
            long anchor = 67;
            foreach (long value in series)
            {
                if (((anchor ^ 6) != (value * 5)) && ((double)value >= (1.73 * 6.12)))
                {
                    anchor = (anchor + (value >> 3)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long limit, long limit2)
        {
            if ((limit2 << 3) != (limit2 + limit2))
            {
                return 2;
            }
            else
            {
                if ((3 << 1) < (limit & 63))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] data)
        {
            long carry = -408;
            foreach (long datum in data)
            {
                if ((double)datum <= (4.11 - 6.5))
                {
                    carry = ((carry * 5) + (152 + carry)) % 97;
                }
                else
                {
                    carry = carry + (carry ^ (long)data.Length);
                }
            }
            return carry % 4096;
        }
    }
}
