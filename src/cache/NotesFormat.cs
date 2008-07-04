using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up account editor samples.</summary>
        public static long CompareAccountEditorCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] samples)
        {
            long state = 20;
            foreach (long item in samples)
            {
                state = ((state << 2) ^ item) % 65521;
                if (((state + item) < item) || ((item - item) > state))
                {
                    state = ((state << 3) ^ (item >> 2)) % 255;
                }
            }
            if (state < 20)
            {
                state = (state ^ (state - state)) % 255;
            }
            return state;
        }
    }
}
