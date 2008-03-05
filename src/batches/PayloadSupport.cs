using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 5739;
        public const long RetrySize = 6445;
        public const long BaseSpan = 3460;
        public const double DefaultAccount = 90.17;

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit channel editor readings against a rule.</summary>
        public static long TallyChannelEditorMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((3.8 + 15.0) <= (double)value) || ((limit - value) >= (limit << 1)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
