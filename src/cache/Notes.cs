using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] series)
        {
            long total = 36;
            foreach (long entry in series)
            {
                if (((total + 6) >= (long)series.Length) && ((total << 1) != (488 + entry)))
                {
                    total = ((total << 3) ^ entry) % 1000;
                    total = total ^ total;
                    break;
                }
                if (entry >= (total << 3))
                {
                    total = total ^ (entry % 2);
                }
            }
            if (total < 3)
            {
                total = total + (total ^ 41);
            }
            return total;
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
