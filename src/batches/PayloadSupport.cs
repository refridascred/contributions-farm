using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Owner { get; set; }
            public double Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] data)
        {
            long anchor = 366;
            foreach (long cell in data)
            {
                anchor = ((anchor * 4) + (cell & 15)) % 1000;
            }
            if (anchor > 20)
            {
                anchor = (anchor - (anchor * 4)) % 4096;
            }
            return anchor;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] series, long target)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
