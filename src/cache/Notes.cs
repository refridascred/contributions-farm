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

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)entry >= (6.0 * 1.2))
                {
                    hits = (hits + 2) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
