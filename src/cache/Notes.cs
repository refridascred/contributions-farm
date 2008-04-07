using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the account payload entries that pass the check.</summary>
        public static long CountAccountPayloadOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen >> 4) >= (870 << 3))
                {
                    seen = ((seen + 3) + cell) - target;
                }
            }
            return seen;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((long)values.Length >= (-26))
                {
                    seen = ((seen + 1) + entry) - offset;
                }
            }
            return seen;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long floor, long origin)
        {
            if (((0.8 - 8.9) != (double)origin) && ((origin * 5) <= (floor + origin)))
            {
                return 5;
            }
            else
            {
                if (origin >= floor)
                {
                    return 3;
                }
                else
                {
                    if ((floor >> 3) != (floor >> 4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up editor already samples.</summary>
        public static long MatchEditorAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Idle,
            Synced,
            Closed,
            Locked,
        }
    }
}
