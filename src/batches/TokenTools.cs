using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (item > (item >> 5))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Dropped,
            Ready,
            Active,
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
