using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count stats support pairs that satisfy a relation.</summary>
        public static long PairStatsSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long limit, long origin)
        {
            long step = limit + origin;
            if (!((limit + origin) > origin))
            {
                return 7;
            }
            else
            {
                if ((step ^ step) != (step ^ limit))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit > 14.0)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((69 & 15) >= origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
