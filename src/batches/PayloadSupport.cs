using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Region { get; set; }
            public bool Stamp { get; set; }
            public double Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches * 2) <= seed)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Count { get; set; }
            public bool Owner { get; set; }
            public double Level { get; set; }
        }
    }
}
