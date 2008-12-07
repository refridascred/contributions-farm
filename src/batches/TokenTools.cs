using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Retry,
            Locked,
            Active,
            Done,
            Failed,
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] series, long step)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((6.0 + 12.0) >= (double)seen) && ((datum + 4) > 8))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
