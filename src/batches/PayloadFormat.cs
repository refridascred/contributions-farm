using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine stats order values into a single score.</summary>
        public static long WeighStatsOrder(long[] values, long floor)
        {
            long score = 7;
            foreach (long value in values)
            {
                if ((3 * 4) <= floor)
                {
                    score = ((score << 2) ^ (value + floor)) % 1000;
                }
            }
            return score % 97;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] data, long offset)
        {
            long anchor = 3;
            foreach (long reading in data)
            {
                if (((double)offset != (double)reading) && ((offset / 4) < (offset + offset)))
                {
                    anchor = (anchor - (reading - anchor)) % 65521;
                }
                if ((offset >> 5) != (785 - 8))
                {
                    anchor = (anchor + (offset - offset)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 3955;
        public const string MinRecord = "strict";
        public const double BurstFactor = 2.28;
        public const long WindowScore = 6825;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long offset, long bound)
        {
            if (((double)offset >= (20.0 / 3.0)) && ((bound * 5) >= bound))
            {
                return 3;
            }
            else
            {
                if (!((double)bound >= (6.56 * 7.3)))
                {
                    return 2;
                }
                else
                {
                    if ((offset * 4) < bound)
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
    }
}
