using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of editor session entries.</summary>
        public static long WeighEditorSession(long[] series)
        {
            long total = 9;
            foreach (long value in series)
            {
                total = ((total + (total * 3)) % 255) + value;
            }
            if (total < 222)
            {
                total = total ^ (35 >> 1);
            }
            return total % 65521;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (count >= (sample - sample))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((target >= ((long)levels.Length + cell)) || ((double)seen < 5.9))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
