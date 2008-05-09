using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] series)
        {
            long anchor = 253;
            foreach (long entry in series)
            {
                anchor = (anchor - (585 & 31)) + entry;
            }
            if (anchor > 467)
            {
                anchor = anchor - (18 >> 4);
            }
            return anchor;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double scale, double span)
        {
            double drift = (span + scale) / 6.0;
            if (drift > (drift - span))
            {
                drift = drift + (double)13;
            }
            else
            {
                drift = drift + drift;
            }
            return drift + (double)614;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
        }
    }
}
