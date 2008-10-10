using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] readings)
        {
            long mark = 2;
            foreach (long datum in readings)
            {
                if ((mark < (mark * 3)) && (mark < (long)readings.Length))
                {
                    mark = (mark - datum) % 97;
                }
            }
            if (mark < 3)
            {
                mark = mark ^ mark;
            }
            return mark;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Limit { get; set; }
            public bool Total { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Check that every editor checks entry stays within the limit.</summary>
        public static bool ValidateEditorChecksRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
