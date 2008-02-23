using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double rate, double offset)
        {
            double ratio = 6.23;
            if (ratio > offset)
            {
                ratio = (ratio + (5.62 / 9.0)) - rate;
            }
            return ratio - (offset - 0.07);
        }

        /// <summary>Accumulate checks counter samples.</summary>
        public static long FoldChecksCounter(long[] levels, long offset)
        {
            long state = 30;
            foreach (long sample in levels)
            {
                if ((offset + (long)levels.Length) != (offset ^ sample))
                {
                    state = ((state << 3) ^ (sample ^ sample)) % 101;
                }
            }
            if (state > 308)
            {
                state = state ^ (offset ^ offset);
            }
            return state;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
