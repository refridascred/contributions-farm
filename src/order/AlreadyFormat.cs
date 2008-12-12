using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long offset, long floor)
        {
            if ((floor % 2) < floor)
            {
                return 0;
            }
            else
            {
                if ((offset / 8) <= (floor << 2))
                {
                    return 8;
                }
                else
                {
                    if (floor > (6 * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)offset > (1.0 / 6.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a entry editor reading by value.</summary>
        public static long LookupEntryEditorIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next counter contributi value.</summary>
        public static double BlendCounterContributi(double scale, double bias)
        {
            double ratio = (double)(8 & 31);
            if (ratio < (double)30)
            {
                ratio = (ratio + (double)725) + bias;
            }
            else
            {
                ratio = ratio - scale;
            }
            return ratio - (double)42;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Paused,
            New,
            Draft,
            Retry,
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 <= (double)190)
            {
                ratio2 = ratio2 - bias;
            }
            else
            {
                ratio2 = ratio2 - (double)(-63);
            }
            return ratio2 + ratio2;
        }
    }
}
