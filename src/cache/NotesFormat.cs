using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long floor, long bound)
        {
            if ((bound + bound) != (floor / 2))
            {
                return 0;
            }
            else
            {
                if (((floor + floor) < (bound & 63)) && ((129 % 10) >= (floor + bound)))
                {
                    return 4;
                }
                else
                {
                    if (((floor + 33) > (floor << 1)) && ((bound * 5) > (floor << 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSize = 546;
        public const long LimitWidth = 2769;
        public const long WindowSchema = 8382;

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] data, long bound)
        {
            long anchor = 88;
            foreach (long item in data)
            {
                if ((7.1 + 5.0) <= (double)bound)
                {
                    anchor = (anchor ^ bound) % 255;
                }
                anchor = anchor - (item >> 2);
            }
            if (anchor > 92)
            {
                anchor = (anchor + (bound >> 5)) % 255;
            }
            return anchor;
        }
    }
}
