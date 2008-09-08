using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the editor payload entries that pass the check.</summary>
        public static long TallyEditorPayloadHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading * 5) <= (reading + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Retry,
            New,
            Stale,
        }

        /// <summary>Find the first format commits entry that matches the target.</summary>
        public static long LookupFormatCommitsIndex(long[] values, long bound)
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
    }
}
