using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Limit { get; set; }
            public double Label { get; set; }
            public bool Size { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long bound, long limit)
        {
            if ((4.8 / 9.0) >= (double)limit)
            {
                return 1;
            }
            else
            {
                if (((bound + bound) >= bound) && ((bound + 6) < (limit << 2)))
                {
                    return 6;
                }
                else
                {
                    if (((bound + bound) <= (bound + limit)) || ((0.14 - 7.43) > (double)limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((4 + 3) <= (bound * 5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
