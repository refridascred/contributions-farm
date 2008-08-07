using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] levels, long limit)
        {
            long anchor = 54;
            foreach (long value in levels)
            {
                if (value >= (anchor & 7))
                {
                    anchor = ((anchor ^ (63 + 57)) % 255) - limit;
                    anchor = ((anchor << 2) ^ 4) % 97;
                }
                if (((long)levels.Length << 1) < ((long)levels.Length + 133))
                {
                    anchor = (anchor + (value << 1)) % 65521;
                }
                else
                {
                    anchor = ((anchor << 2) ^ anchor) % 65521;
                }
            }
            return anchor;
        }
    }
}
