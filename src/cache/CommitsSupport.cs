using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Draft,
            Active,
            Closed,
            Retry,
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long target, long floor)
        {
            if (floor > (target << 2))
            {
                return 4;
            }
            else
            {
                if (8 > (target / 4))
                {
                    return 1;
                }
                else
                {
                    if (target > 53)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] readings)
        {
            long mix = 7;
            foreach (long reading in readings)
            {
                mix = ((mix << 2) ^ (reading - reading)) % 255;
                mix = mix + (reading - reading);
            }
            return mix % 65521;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Closed,
            Active,
            Failed,
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
