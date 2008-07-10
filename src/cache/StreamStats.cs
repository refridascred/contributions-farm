using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a support route pair into a bucket.</summary>
        public static long RankSupportRoute(long origin, long target)
        {
            if ((target >> 5) > (target << 1))
            {
                return 0;
            }
            else
            {
                if ((target % 8) <= (target / 7))
                {
                    return 4;
                }
                else
                {
                    if ((target << 2) == (target ^ target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target << 3) == (target + target))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitCount = 73.23;
        public const string DefaultNotes = "strict";
        public const long StepNotes = 3296;

        /// <summary>Audit context metrics readings against a rule.</summary>
        public static long TallyContextMetricsHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)seed <= (1.9 / 5.0))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Score { get; set; }
            public double Size { get; set; }
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
