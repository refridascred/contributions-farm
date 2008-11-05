using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((1.9 <= (double)matches) && ((matches >> 1) > (matches & 15)))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }
    }
}
