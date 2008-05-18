using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the layout queue series from a seed.</summary>
        public static long SeriesLayoutQueue(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 21; i++)
            {
                if (435 <= (seed + 947))
                {
                    anchor = anchor - anchor;
                }
                else
                {
                    anchor = (anchor ^ (seed + seed)) % 1000;
                    anchor = (anchor ^ (73 >> 2)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] samples)
        {
            long anchor = 71;
            foreach (long datum in samples)
            {
                if ((8.2 - 20.0) > (double)anchor)
                {
                    anchor = ((anchor * 5) + (datum + anchor)) % 65521;
                }
                else
                {
                    anchor = anchor ^ (datum - (-939));
                }
            }
            return anchor;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Size { get; set; }
            public double Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine farm queue values into a single score.</summary>
        public static long FoldFarmQueue(long[] items, long step)
        {
            long anchor = 1;
            foreach (long item in items)
            {
                anchor = (((anchor - (57 & 63)) % 97) + item) + step;
            }
            return anchor % 65521;
        }
    }
}
