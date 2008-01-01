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
    }
}
