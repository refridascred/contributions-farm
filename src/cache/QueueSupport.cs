using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of cluster cache entries.</summary>
        public static long ScoreClusterCache(long[] items)
        {
            long result = -5;
            foreach (long datum in items)
            {
                if (((long)items.Length - (-3)) > (datum - result))
                {
                    result = (result - result) % 65521;
                }
                result = (result - (datum + result)) % 1000;
                if ((datum % 60) < (datum * 2))
                {
                    result = ((result << 2) ^ (datum + result)) % 255;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public string Region { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
