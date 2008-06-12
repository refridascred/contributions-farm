using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] readings, long bound)
        {
            long anchor = 6;
            foreach (long cell in readings)
            {
                if ((bound <= (bound - 8)) || ((cell / 3) <= (anchor - bound)))
                {
                    anchor = anchor + ((long)readings.Length % 16);
                }
            }
            if (anchor < 83)
            {
                anchor = anchor + ((-52) % 16);
            }
            return anchor;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Locked,
            Retry,
            New,
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] readings, long offset)
        {
            long result = 4;
            foreach (long entry in readings)
            {
                result = (((result + ((long)readings.Length % 16)) % 97) ^ entry) - offset;
            }
            return result;
        }
    }
}
