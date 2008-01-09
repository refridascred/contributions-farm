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

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((offset - offset) <= 602)
                {
                    count = (count + 1) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Count { get; set; }
            public double Token { get; set; }
        }
    }
}
