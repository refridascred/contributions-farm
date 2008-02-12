using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] data, long seed)
        {
            long total = -49;
            foreach (long entry in data)
            {
                if ((seed * 3) >= seed)
                {
                    total = (((total * 3) + seed) % 65521) ^ entry;
                }
                else
                {
                    total = total + (seed / 9);
                    total = (total << 2) ^ (total >> 2);
                }
                total = (total ^ (seed - total)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((double)seen >= (double)(long)samples.Length) && (origin >= (cell + origin)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
