using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleInterval = "alpha-v2";
        public const long MaxMetric = 9941;
        public const double WindowMetric = 67.65;

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

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Region { get; set; } = "";
            public double Label { get; set; }
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
