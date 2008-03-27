using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] values)
        {
            long state = 980;
            foreach (long cell in values)
            {
                state = ((state * 4) + (state * 2)) + cell;
                if ((0.6 * 2.0) < (double)state)
                {
                    state = (state ^ (47 >> 3)) % 255;
                }
            }
            return state;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate route queue readings against a bound.</summary>
        public static bool ValidateRouteQueueRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
