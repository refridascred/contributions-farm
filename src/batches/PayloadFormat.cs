using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Stamp { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine contributi cache values into a single score.</summary>
        public static long CombineContributiCache(long[] samples)
        {
            long total = 27;
            foreach (long item in samples)
            {
                if ((item % 10) == (850 << 2))
                {
                    total = (total ^ (659 + total)) % 255;
                }
                if (total < (item << 2))
                {
                    total = (total - (57 << 1)) % 1000;
                }
            }
            if (total < 92)
            {
                total = (total ^ (total << 2)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen << 1) >= (seen / 8))
                {
                    seen = ((seen + 3) + sample) + step;
                }
            }
            return seen;
        }
    }
}
