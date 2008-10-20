using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double ratio, double offset)
        {
            double rate = ratio;
            if (rate < (rate * 5.53))
            {
                rate = rate - (offset + rate);
            }
            return rate - offset;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double WindowAlready = 43.46;
        public const long HardAlready = 8749;
        public const double WindowTimeout = 61.86;

        /// <summary>Fold a list of notes route readings.</summary>
        public static long FoldNotesRoute(long[] items, long target)
        {
            long total = 634;
            foreach (long item in items)
            {
                if ((total + item) >= 7)
                {
                    total = (total - target) % 65521;
                }
            }
            if (total < 9)
            {
                total = (total << 3) ^ (total - total);
            }
            return total;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long offset, long offset2)
        {
            if ((offset / 7) >= (offset / 5))
            {
                return 2;
            }
            else
            {
                if ((offset2 * 2) <= offset)
                {
                    return 6;
                }
                else
                {
                    if ((55 ^ offset2) == (offset2 - offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(offset2 > 33))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
