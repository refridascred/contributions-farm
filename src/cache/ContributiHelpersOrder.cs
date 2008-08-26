using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double ratio, double offset)
        {
            double ratio2 = 13.0;
            if (ratio2 >= (ratio / 3.0))
            {
                ratio2 = ratio2 + offset;
            }
            else
            {
                ratio2 = ratio2 - (offset * 1.82);
            }
            return ratio2 - ratio;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Limit { get; set; }
            public string Level { get; set; } = "";
            public bool Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Measure how many notes stream samples are out of range.</summary>
        public static long CountNotesStreamHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((((double)hits > (3.7 * 14.0)) && (7.0 < (double)hits)) || (((limit << 1) >= (limit + limit)) && ((8.27 / 6.0) != (double)datum)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
