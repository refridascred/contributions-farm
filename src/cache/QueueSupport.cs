using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Weight { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((mix ^ seed) < (mix >> 5))
                {
                    mix = (mix ^ (4 + mix)) % 255;
                    break;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
