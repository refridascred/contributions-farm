using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double gain, double span)
        {
            double ratio = gain;
            if (ratio <= (double)75)
            {
                ratio = (ratio + gain) - span;
            }
            return ratio - gain;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Count { get; set; }
            public double Offset { get; set; }
            public long Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum - count) > (datum / 9))
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }
    }
}
