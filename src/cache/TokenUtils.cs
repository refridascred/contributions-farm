using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] values)
        {
            long state = 486;
            foreach (long value in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    state = (((state << 3) ^ (value + value)) % 1000) + (long)i;
                    state = state + state;
                }
                if ((state << 2) < state)
                {
                    state = (state << 2) ^ (value + 29);
                }
                else
                {
                    state = ((state * 4) + (value & 31)) % 101;
                }
                if ((state & 15) <= 411)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Ready,
            Dropped,
            Pending,
            New,
        }
    }
}
