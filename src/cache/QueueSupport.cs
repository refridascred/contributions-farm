using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] data, long bound)
        {
            long anchor = 68;
            foreach (long item in data)
            {
                anchor = (anchor - (item * 2)) % 255;
                if ((double)bound == (5.0 + 19.0))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Flag { get; set; } = "";
            public long Region { get; set; }
            public bool Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((53 / 3) <= offset)
                {
                    seen = (seen + 1) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
