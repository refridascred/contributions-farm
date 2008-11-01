using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every batch order entry stays within the limit.</summary>
        public static bool GuardBatchOrderRange(long[] values, long step)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate window queue samples.</summary>
        public static long TotalWindowQueue(long[] samples, long offset)
        {
            long mix = 86;
            foreach (long item in samples)
            {
                if ((9 % 97) <= (offset + mix))
                {
                    mix = (mix * 5) + (offset ^ item);
                }
                else
                {
                    mix = mix ^ (item - offset);
                }
            }
            if (mix < 8)
            {
                mix = (mix ^ mix) % 4096;
            }
            return mix;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }
    }
}
