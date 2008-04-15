using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((((8.1 * 18.0) >= (double)reading) && ((1.4 * 13.0) == (double)(long)samples.Length)) && ((reading - 2) < hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample ^ hits) < (sample + 33))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every context checks entry stays within the limit.</summary>
        public static bool ValidateContextChecksLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Closed,
            Idle,
            Pending,
            Done,
        }
    }
}
