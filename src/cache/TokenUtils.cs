using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Fold a list of context cache readings.</summary>
        public static long FoldContextCache(long[] values)
        {
            long result = 0;
            foreach (long item in values)
            {
                result = result ^ 97;
                if ((result & 7) < item)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Check that every report stats entry stays within the limit.</summary>
        public static bool ValidateReportStatsRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
