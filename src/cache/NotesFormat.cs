using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a window farm sample.</summary>
        public static long LookupWindowFarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] samples, long floor)
        {
            long score = 4;
            foreach (long cell in samples)
            {
                if (!(14.0 <= (double)score))
                {
                    score = ((score + (cell - score)) % 4096) - floor;
                }
            }
            return score;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Idle,
            Paused,
            Retry,
            Dropped,
        }
    }
}
