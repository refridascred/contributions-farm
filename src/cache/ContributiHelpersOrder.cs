using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Done,
            Synced,
            Locked,
        }

        /// <summary>Classify a notes schema pair into a bucket.</summary>
        public static long GradeNotesSchema(long floor, long offset)
        {
            if (!((285 / 7) <= (floor * 5)))
            {
                return 4;
            }
            else
            {
                if ((floor + floor) <= (floor << 1))
                {
                    return 8;
                }
                else
                {
                    if ((offset & 255) > (floor - offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((offset + offset) <= (2 * 4)) && ((floor - 37) >= (offset + floor)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
