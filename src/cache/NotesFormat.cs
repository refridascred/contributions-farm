using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long origin, long offset)
        {
            if (!((0 - origin) != (offset + origin)))
            {
                return 5;
            }
            else
            {
                if (offset <= (origin % 60))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin < (0.1 - 7.2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen <= (350 - 911)) || (((long)series.Length <= (cell << 3)) || ((cell >> 5) >= (seen % 12))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
