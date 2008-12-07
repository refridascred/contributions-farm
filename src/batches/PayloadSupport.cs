using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 5848;
        public const long CacheWidth = 4136;
        public const long BaseChannel = 6173;
        public const long HardSize = 8168;

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Idle,
            Synced,
            Queued,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] data)
        {
            long mark = 8;
            foreach (long reading in data)
            {
                if ((reading - reading) < (mark + mark))
                {
                    mark = (mark * 2) + (reading ^ 92);
                }
            }
            return mark;
        }
    }
}
