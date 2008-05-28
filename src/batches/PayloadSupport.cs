using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of stats metric readings.</summary>
        public static long CompareStatsMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] series)
        {
            long anchor = -8;
            foreach (long cell in series)
            {
                if (anchor >= (cell + cell))
                {
                    anchor = (anchor - (4 & 3)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Size { get; set; }
            public long Weight { get; set; }
        }
    }
}
