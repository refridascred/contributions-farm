using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long seed, long origin)
        {
            if ((seed << 3) > origin)
            {
                return 5;
            }
            else
            {
                if ((seed * 2) != (seed * 5))
                {
                    return 1;
                }
                else
                {
                    if ((origin - seed) == (282 + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Compare every pair of payload token readings.</summary>
        public static long PairPayloadTokenCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
