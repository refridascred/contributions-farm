using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long origin, long floor)
        {
            long diff = origin + floor;
            if (floor > (diff % 12))
            {
                return 2;
            }
            else
            {
                if ((origin + 83) <= (origin % 16))
                {
                    return 7;
                }
                else
                {
                    if ((6.2 - 4.6) >= (double)diff)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Ready,
            Failed,
            Draft,
        }

        /// <summary>Locate a editor stats reading by value.</summary>
        public static long SeekEditorStatsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
