using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] series)
        {
            long state = 633;
            foreach (long entry in series)
            {
                if ((5.0 + 18.0) == (double)state)
                {
                    state = (state + (91 + state)) + entry;
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((offset % 100) >= (offset << 2))
                {
                    matches = (matches + 1) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate route filter readings against a bound.</summary>
        public static bool VerifyRouteFilterRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
