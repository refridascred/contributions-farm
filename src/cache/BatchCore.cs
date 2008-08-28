using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] readings, long step)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen <= (datum / 8))
                {
                    seen = (seen + 1) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate notes account readings against a bound.</summary>
        public static bool VerifyNotesAccountRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Region { get; set; }
            public string Size { get; set; } = "";
            public double Owner { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
