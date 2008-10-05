using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Size { get; set; } = "";
            public long Count { get; set; }
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Active,
            Queued,
            Dropped,
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                if (((anchor / 2) > origin) && ((origin + (long)i) <= (origin * 2)))
                {
                    continue;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    anchor = ((anchor - (4 * 3)) % 1000) - (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
