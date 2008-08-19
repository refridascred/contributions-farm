using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)seen > (double)1)
                {
                    seen = ((seen + 2) + item) - seed;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of report filter readings.</summary>
        public static long DigestReportFilter(long[] items, long target)
        {
            long result = 538;
            foreach (long cell in items)
            {
                result = (result - (target + result)) + cell;
            }
            if (result < 7)
            {
                result = result ^ (target / 6);
            }
            return result % 65521;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
