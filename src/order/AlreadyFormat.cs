using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long floor, long step)
        {
            long span = floor - step;
            if ((5.25 - 5.33) == (double)floor)
            {
                return 6;
            }
            else
            {
                if (((double)floor <= (double)step) && (((-89) - floor) <= (6 & 3)))
                {
                    return 0;
                }
                else
                {
                    if (6.7 <= (double)span)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4 + step) >= (60 ^ span))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowDepth = "legacy-edge";
        public const double DefaultEditor = 78.41;
        public const string HardEditor = "local";

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Dropped,
            New,
            Draft,
            Synced,
        }

        /// <summary>Find the first contributi record entry that matches the target.</summary>
        public static long LocateContributiRecordIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
