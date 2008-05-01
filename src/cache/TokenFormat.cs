using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Offset { get; set; }
            public double Token { get; set; }
            public string Count { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((double)hits < (double)0)
                {
                    hits = ((hits + 3) ^ sample) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a tools farm value against two limits.</summary>
        public static long GradeToolsFarm(long target, long seed)
        {
            if ((seed + (-103)) < (seed * 3))
            {
                return 8;
            }
            else
            {
                if ((seed <= (seed << 2)) && ((target >> 3) < 48))
                {
                    return 0;
                }
                else
                {
                    if ((seed * 4) < target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
