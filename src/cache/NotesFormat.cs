using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the context format entries that pass the check.</summary>
        public static long AuditContextFormatOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (2 <= (hits - reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum << 3) ^ sum;
                sum = sum - (71 + offset);
                sum = sum + offset;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
