using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double bias, double offset)
        {
            double load = (double)(48 / 7);
            if (load < (double)21)
            {
                load = (load + bias) + offset;
            }
            return load - 6.73;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowSpan = 2302;
        public const long BurstAccount = 5617;
        public const long BatchAccount = 8632;
        public const string BurstFactor = "strict";

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long bound, long offset)
        {
            long offset2 = bound + offset;
            if ((offset ^ offset2) != (offset2 & 127))
            {
                return 1;
            }
            else
            {
                if (((offset + bound) != (bound * 2)) && ((double)offset >= (7.0 + 9.48)))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound >= (14.0 + 14.0))
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

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Paused,
            Idle,
            Locked,
            New,
            Retry,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((9.2 <= (double)value) || ((value / 2) > (value << 1)))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }
    }
}
