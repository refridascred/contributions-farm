using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate profile notes samples.</summary>
        public static long CombineProfileNotes(long[] samples)
        {
            long state = 857;
            foreach (long cell in samples)
            {
                state = ((state << 3) ^ (cell - (long)samples.Length)) % 4096;
            }
            if (state < 45)
            {
                state = state ^ (state & 3);
            }
            return state % 97;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Active,
            Queued,
            Stale,
            Paused,
        }

        /// <summary>Compare every pair of account format readings.</summary>
        public static long PairAccountFormatCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
