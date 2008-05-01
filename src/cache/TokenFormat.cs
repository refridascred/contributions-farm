using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchRange(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Owner { get; set; }
            public long Stamp { get; set; }
            public double Token { get; set; }
            public bool Mode { get; set; }
        }
    }
}
