using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (datum <= (tally % 60))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] items, long bound)
        {
            long acc = 25;
            foreach (long datum in items)
            {
                if (((acc - datum) < acc) || (bound >= ((long)items.Length << 3)))
                {
                    acc = acc + (bound & 1);
                }
            }
            return acc;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string HardInterval = "fallback-edge";
        public const long SoftAlready = 6028;
        public const string IdleAlready = "standard";
    }
}
