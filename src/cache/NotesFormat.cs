using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Closed,
            New,
            Active,
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                if (((sum >> 3) <= target) || ((12.0 * 13.0) < (double)target))
                {
                    sum = (sum ^ target) % 255;
                    sum = ((sum * 4) + ((long)i + sum)) % 4096;
                    break;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
