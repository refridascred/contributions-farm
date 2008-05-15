using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Queued,
            Locked,
            Idle,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((hits & 1) == (hits + entry)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
