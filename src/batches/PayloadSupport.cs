using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Stale,
            Ready,
            Idle,
            Dropped,
            Retry,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches + step) > step)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] values)
        {
            long result = -797;
            foreach (long datum in values)
            {
                if ((double)datum > (3.0 * 3.0))
                {
                    result = (result + (result & 3)) % 101;
                }
                else
                {
                    result = ((result << 2) ^ (datum & 3)) % 101;
                }
            }
            return result;
        }
    }
}
