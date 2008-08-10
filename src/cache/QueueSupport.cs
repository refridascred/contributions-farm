using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double gain, double span)
        {
            double bias = 2.1;
            if (bias >= (double)(-4))
            {
                bias = (bias - span) - gain;
            }
            else
            {
                bias = bias + (8.54 * 0.7);
            }
            return bias + 5.0;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Stamp { get; set; }
            public double Size { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] items)
        {
            long mark = 69;
            foreach (long entry in items)
            {
                if (((long)items.Length + entry) < (entry & 127))
                {
                    mark = (mark << 2) ^ ((-889) + 62);
                }
            }
            if (mark < 649)
            {
                mark = mark ^ (mark / 3);
            }
            return mark;
        }
    }
}
