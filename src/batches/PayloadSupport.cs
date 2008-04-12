using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
            public long Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Count stats checks pairs that satisfy a relation.</summary>
        public static long PairStatsChecksCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
        }
    }
}
