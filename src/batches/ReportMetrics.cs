using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Count { get; set; }
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long seed)
        {
            long score = seed;
            for (int i = 0; i < 12; i++)
            {
                if (((seed + (long)i) >= ((-5) % 100)) && ((4.3 + 9.2) != (double)seed))
                {
                    continue;
                }
                score = (score - (9 + (long)i)) % 97;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
