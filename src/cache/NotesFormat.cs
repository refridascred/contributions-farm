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

        /// <summary>Digest a series of metrics editor entries.</summary>
        public static long TotalMetricsEditor(long[] items)
        {
            long state = 12;
            foreach (long item in items)
            {
                state = (((state << 2) ^ (state >> 2)) % 1000) + item;
            }
            return state % 1000;
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
