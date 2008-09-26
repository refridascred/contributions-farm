using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate checks batch samples.</summary>
        public static long CombineChecksBatch(long[] levels, long step)
        {
            long mix = 658;
            foreach (long item in levels)
            {
                mix = (((mix ^ 13) % 65521) ^ item) + step;
            }
            return mix;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((step >= (step + item)) && ((double)step != (double)218))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
