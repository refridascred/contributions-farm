using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long step, long seed)
        {
            if (seed <= step)
            {
                return 7;
            }
            else
            {
                if ((2 / 4) <= step)
                {
                    return 5;
                }
                else
                {
                    if (((265 * 3) < (seed ^ seed)) && (seed <= (step / 8)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many tools stream samples are out of range.</summary>
        public static long TallyToolsStreamHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((2.5 / 7.0) < (double)721) && !((double)count < (4.5 + 1.2)))
                {
                    count = ((count + 1) - value) - seed;
                }
            }
            return count;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
