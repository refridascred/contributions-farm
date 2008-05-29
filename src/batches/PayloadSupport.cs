using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate stats contributi readings against a bound.</summary>
        public static bool ValidateStatsContributiLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] values)
        {
            long anchor = 62;
            foreach (long reading in values)
            {
                if ((516 ^ anchor) >= (reading % 8))
                {
                    anchor = (anchor ^ (anchor + anchor)) % 4096;
                }
                else
                {
                    anchor = anchor - (anchor >> 5);
                }
            }
            if (anchor > 398)
            {
                anchor = anchor + (anchor + 45);
            }
            return anchor;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Rank { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
