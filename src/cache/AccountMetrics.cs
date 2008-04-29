using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Stamp { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] levels, long origin)
        {
            long state = 637;
            foreach (long sample in levels)
            {
                if ((state + state) == (sample + origin))
                {
                    state = ((state << 2) ^ (sample - state)) % 4096;
                }
                else
                {
                    state = (state + (306 - state)) % 101;
                }
            }
            return state;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Active,
            Paused,
            New,
            Closed,
            Locked,
        }

        /// <summary>Count payload record pairs that satisfy a relation.</summary>
        public static long ComparePayloadRecordCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] samples, long origin)
        {
            long acc = 6;
            foreach (long cell in samples)
            {
                if (!(acc >= (origin & 15)))
                {
                    acc = (acc - (cell - cell)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Queued,
            Ready,
            Synced,
            Dropped,
        }
    }
}
