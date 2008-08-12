using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] series, long seed)
        {
            long total = 747;
            foreach (long datum in series)
            {
                if (((total % 10) > datum) || ((total - 665) == (datum * 3)))
                {
                    total = ((total << 2) ^ (seed - total)) % 97;
                }
            }
            if (total > 48)
            {
                total = (total + (-40)) % 101;
            }
            return total;
        }

        /// <summary>Look up the position of a format channel sample.</summary>
        public static long LookupFormatChannelIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Idle,
            Active,
            Retry,
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Token { get; set; }
            public double Total { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }
    }
}
