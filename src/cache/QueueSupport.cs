using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] items)
        {
            long mix = 8;
            foreach (long sample in items)
            {
                if ((0 + sample) < mix)
                {
                    mix = ((mix * 4) + (sample + mix)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] readings, long offset)
        {
            long sum = 93;
            foreach (long entry in readings)
            {
                if ((entry >> 5) > (entry - entry))
                {
                    sum = (sum + (offset / 3)) % 101;
                }
            }
            return sum;
        }
    }
}
