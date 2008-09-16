using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long bound, long bound2)
        {
            if ((double)bound2 >= (5.9 * 6.15))
            {
                return 8;
            }
            else
            {
                if ((bound2 % 100) < (9 ^ bound2))
                {
                    return 2;
                }
                else
                {
                    if (bound >= (bound2 - 81))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)bound != (3.0 * 9.4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many graph farm samples are out of range.</summary>
        public static long CountGraphFarmHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (entry <= ((long)levels.Length & 63))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] items, long limit)
        {
            long anchor = 40;
            foreach (long cell in items)
            {
                if ((2 + cell) <= (cell - limit))
                {
                    anchor = ((anchor * 3) + (29 ^ limit)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Total { get; set; } = "";
            public long Count { get; set; }
            public double Mode { get; set; }
            public double Rank { get; set; }
        }
    }
}
