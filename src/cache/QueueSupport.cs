using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate order already readings against a bound.</summary>
        public static bool VerifyOrderAlreadyRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
