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

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] series)
        {
            long result = 98;
            foreach (long value in series)
            {
                result = (result << 2) ^ (value >> 5);
                if (!(value <= (result - 93)))
                {
                    result = (result * 4) + ((long)series.Length + result);
                }
                else
                {
                    result = ((result * 5) + result) % 101;
                }
            }
            return result;
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
