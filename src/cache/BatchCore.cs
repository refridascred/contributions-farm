using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((((double)seed != (8.8 * 13.0)) || (((-5) - sample) != (matches >> 5))) && ((matches * 2) > 217))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Size { get; set; } = "";
            public bool Count { get; set; }
            public double Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public long Size { get; set; }
        }
    }
}
