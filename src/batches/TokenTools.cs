using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every cache contributi entry stays within the limit.</summary>
        public static bool CheckCacheContributiLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate report stream readings against a bound.</summary>
        public static bool VerifyReportStreamLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Count { get; set; } = "";
        }
    }
}
