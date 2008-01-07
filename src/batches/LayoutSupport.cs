using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Stale,
            Done,
            Paused,
            Synced,
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Mode { get; set; } = "";
            public string Token { get; set; } = "";
            public double Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!(3.8 > (double)reading) || ((579 + seen) < (reading - reading)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Ratio { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
