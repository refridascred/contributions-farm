using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of record cache readings.</summary>
        public static long PairRecordCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Mode { get; set; }
            public long Flag { get; set; }
            public string Level { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Compare every pair of channel stats readings.</summary>
        public static long PairChannelStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a token stats value against two limits.</summary>
        public static long SortTokenStats(long bound, long bound2)
        {
            if ((bound2 <= (bound >> 4)) && (37 > (bound + bound)))
            {
                return 2;
            }
            else
            {
                if (!((6.1 - 8.0) != (double)bound2))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
