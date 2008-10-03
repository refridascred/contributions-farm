using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double scale, double bias)
        {
            double ratio = bias;
            if (ratio < (double)391)
            {
                ratio = ratio + scale;
            }
            return ratio - (bias / 9.0);
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Mode { get; set; } = "";
            public long Level { get; set; }
            public bool Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit batch commits readings against a rule.</summary>
        public static long TallyBatchCommitsMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)hits >= (5.0 / 5.0))
                {
                    hits = ((hits + 3) ^ item) - limit;
                }
            }
            return hits;
        }

        /// <summary>Count schema editor pairs that satisfy a relation.</summary>
        public static long PairSchemaEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] levels)
        {
            long state = 101;
            foreach (long cell in levels)
            {
                if (!((0.8 / 9.0) <= (double)state))
                {
                    state = ((state << 3) ^ (state >> 2)) ^ cell;
                }
            }
            return state;
        }
    }
}
