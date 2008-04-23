using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((floor + cell) == (cell + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public string Weight { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
