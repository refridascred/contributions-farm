using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the buffer commits entries that pass the check.</summary>
        public static long TallyBufferCommitsMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((tally - (long)samples.Length) > (tally / 3)) || (((long)samples.Length * 5) <= (tally * 5)))
                {
                    tally = (tally + 1) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Closed,
            Done,
            Queued,
            New,
            Retry,
        }
    }
}
