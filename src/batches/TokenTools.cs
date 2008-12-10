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

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] data, long offset)
        {
            long state = 3;
            foreach (long cell in data)
            {
                state = ((state + cell) % 1000) + offset;
            }
            return state;
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
