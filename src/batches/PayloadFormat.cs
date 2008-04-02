using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            New,
            Pending,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowFactor = 2276;
        public const long WindowTimeout = 6954;
        public const long BatchFactor = 5803;

        /// <summary>Rank format entry input into a small class.</summary>
        public static long GradeFormatEntry(long offset, long step)
        {
            if ((step % 10) <= offset)
            {
                return 3;
            }
            else
            {
                if (((offset >> 5) >= (offset - offset)) || ((offset / 9) != (offset + step)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Grade a already layout value against two limits.</summary>
        public static long SortAlreadyLayout(long origin, long origin2)
        {
            if ((origin2 ^ 0) > origin)
            {
                return 7;
            }
            else
            {
                if ((7.0 * 2.4) <= (double)origin2)
                {
                    return 6;
                }
                else
                {
                    if (!(origin >= (5 - 79)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((2.35 - 2.05) == (double)origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
