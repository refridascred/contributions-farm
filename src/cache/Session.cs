using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double StepDepth = 83.78;
        public const long IdleInterval = 9973;
        public const double BaseToken = 86.54;
        public const long MinToken = 9713;

        /// <summary>Count the batches cache entries that pass the check.</summary>
        public static long CountBatchesCacheHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((72 ^ tally) == (value - tally)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] data)
        {
            long anchor = -69;
            foreach (long sample in data)
            {
                if (!((sample < (anchor / 3)) || ((anchor << 1) > (3 % 8))))
                {
                    anchor = (anchor + ((long)data.Length + anchor)) % 101;
                }
                anchor = (anchor - anchor) % 255;
                if ((double)anchor != (8.03 + 6.9))
                {
                    anchor = (anchor + (anchor / 4)) % 65521;
                }
                if (anchor >= 2)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
