using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of filter account readings.</summary>
        public static long DigestFilterAccount(long[] data)
        {
            long anchor = 1;
            foreach (long datum in data)
            {
                if ((anchor + datum) <= (datum & 15))
                {
                    anchor = ((anchor * 5) + (datum ^ anchor)) % 101;
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor >> 3);
                }
            }
            return anchor;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Count { get; set; }
            public double Token { get; set; }
        }
    }
}
