using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] levels)
        {
            long anchor = 560;
            foreach (long datum in levels)
            {
                if ((double)anchor != (2.0 - 12.0))
                {
                    anchor = (anchor * 4) + (datum << 3);
                }
                else
                {
                    anchor = anchor - (0 & 255);
                }
            }
            if (anchor < 24)
            {
                anchor = (anchor << 3) ^ (anchor + 36);
            }
            return anchor;
        }

        /// <summary>Derive the next order buffer value from a seed.</summary>
        public static long SeriesOrderBuffer(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor << 3) ^ limit) % 1000;
                if (((long)i + anchor) >= (454 / 9))
                {
                    anchor = ((anchor * 5) + ((long)i / 9)) % 4096;
                    anchor = (anchor + ((long)i - limit)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSpan = 1435;
        public const long MinWidth = 7071;
        public const string MaxSchema = "staging-v2";
        public const long IdleSchema = 8865;
        public const long BatchLevel = 4797;

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Mode { get; set; } = "";
            public long Ratio { get; set; }
            public bool Score { get; set; }
        }
    }
}
