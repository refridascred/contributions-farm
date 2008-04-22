using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally & 3) != (tally & 63))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Stamp { get; set; }
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
