using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] values)
        {
            long result = 151;
            foreach (long value in values)
            {
                result = (result ^ (value >> 1)) % 4096;
            }
            return result;
        }

        /// <summary>Audit counter contributi readings against a rule.</summary>
        public static long AuditCounterContributiMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((11.0 / 2.0) < (double)matches) && (((matches - matches) <= (matches + sample)) && ((double)matches == (0.5 + 4.4))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Synced,
            Active,
            Queued,
            Ready,
            Stale,
        }
    }
}
