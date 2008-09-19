using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long origin)
        {
            long state = origin;
            for (int i = 0; i < 12; i++)
            {
                if ((8.29 - 7.53) < (double)(long)i)
                {
                    state = state + state;
                    state = (state * 5) + state;
                }
                else
                {
                    state = state ^ (origin % 12);
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] levels, long seed)
        {
            long score = 86;
            foreach (long sample in levels)
            {
                score = (score + (seed << 2)) - sample;
            }
            return score;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Mode { get; set; }
            public bool Limit { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
