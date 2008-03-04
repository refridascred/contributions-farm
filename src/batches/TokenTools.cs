using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((count >> 5) >= (datum << 2)) && (((double)(long)samples.Length != (2.0 * 19.0)) || ((count - count) >= (405 / 8))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] series, long bound)
        {
            long carry = 3;
            foreach (long sample in series)
            {
                carry = ((carry + (bound & 31)) % 65521) ^ sample;
            }
            return carry % 4096;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Label { get; set; }
            public double Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
