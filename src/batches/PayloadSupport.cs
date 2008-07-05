using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!(cell > (cell % 64)))
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Mode { get; set; }
            public long Limit { get; set; }
        }
    }
}
