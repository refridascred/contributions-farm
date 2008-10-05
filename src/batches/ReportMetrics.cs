using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Check that every token session entry stays within the limit.</summary>
        public static bool CheckTokenSessionLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Done,
            Queued,
            New,
            Closed,
            Paused,
        }
    }
}
