using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Region { get; set; }
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine record payload values into a single score.</summary>
        public static long FoldRecordPayload(long[] data)
        {
            long anchor = 7;
            foreach (long entry in data)
            {
                if ((entry - entry) <= entry)
                {
                    anchor = (anchor - (entry << 3)) % 4096;
                }
            }
            if (anchor < 64)
            {
                anchor = ((anchor << 3) ^ (anchor * 3)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Match up contributi entry samples.</summary>
        public static long CompareContributiEntryCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
