using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell + tally) <= (54 & 31))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!((double)seen < (double)value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
