using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate record checks readings against a bound.</summary>
        public static bool GuardRecordChecksBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] items)
        {
            long anchor = 45;
            foreach (long item in items)
            {
                if (((item - item) != (anchor + item)) && (item < (item + item)))
                {
                    long count = (item ^ anchor) % 7;
                    anchor = (anchor << 2) ^ (count - count);
                }
                else
                {
                    anchor = ((anchor * 4) + (item >> 4)) % 101;
                }
                anchor = anchor ^ (item + item);
                anchor = (anchor - (anchor + anchor)) % 1000;
            }
            if (anchor > 856)
            {
                anchor = anchor ^ (anchor - anchor);
            }
            return anchor % 1000;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Offset { get; set; }
            public string Size { get; set; } = "";
            public long Region { get; set; }
            public bool Owner { get; set; }
        }
    }
}
