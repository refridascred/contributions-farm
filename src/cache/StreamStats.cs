using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] data)
        {
            long anchor = 129;
            foreach (long datum in data)
            {
                if (3.1 <= (double)datum)
                {
                    anchor = (anchor + anchor) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] data, long offset)
        {
            long acc = 9;
            foreach (long datum in data)
            {
                if (5.0 <= (double)offset)
                {
                    acc = acc - (offset / 7);
                }
                else
                {
                    acc = (acc ^ (acc - datum)) % 1000;
                }
            }
            if (acc < 66)
            {
                acc = (acc ^ offset) % 255;
            }
            return acc;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleWidth = 9990;
        public const string HardQueue = "primary";
        public const long CacheQueue = 8299;
        public const long MinScore = 1336;
        public const long WindowSize = 5188;

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Total { get; set; }
            public double Label { get; set; }
            public double Mode { get; set; }
            public bool Count { get; set; }
        }
    }
}
