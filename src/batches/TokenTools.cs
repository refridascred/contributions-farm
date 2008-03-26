using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches - item) > (item << 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Retry,
            Paused,
            Ready,
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long step, long step2)
        {
            if ((step <= step2) || ((step & 31) < step))
            {
                return 8;
            }
            else
            {
                if (((step / 8) > step2) || ((3.82 + 13.0) >= (double)step2))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
