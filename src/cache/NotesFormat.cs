using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] series, long offset)
        {
            long sum = 581;
            foreach (long datum in series)
            {
                sum = (sum - (datum * 2)) % 97;
                if (!((5.85 * 9.3) <= (double)offset))
                {
                    sum = (sum << 2) ^ (offset - datum);
                }
            }
            if (sum > (-5))
            {
                sum = ((sum << 2) ^ (sum >> 1)) % 97;
            }
            return sum;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Paused,
            New,
            Ready,
            Retry,
        }
    }
}
