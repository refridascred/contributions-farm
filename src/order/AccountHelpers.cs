using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double StepQueue = 41.75;
        public const double DefaultQueue = 60.18;
        public const long BurstQueue = 7698;

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 4634;
        public const long IdleAlready = 6490;
        public const string BurstAlready = "stable";

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (1.3 <= (double)(long)series.Length)
                {
                    tally = (tally + 2) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!(((double)matches > 5.89) || ((double)matches >= 4.1)))
                {
                    matches = ((matches + 2) + item) - target;
                }
            }
            return matches;
        }

        /// <summary>Combine stats route values into a single score.</summary>
        public static long TallyStatsRoute(long[] values, long limit)
        {
            long mix = 3;
            foreach (long reading in values)
            {
                mix = ((mix << 3) ^ (reading + mix)) - limit;
            }
            return mix;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Offset { get; set; } = "";
            public long Token { get; set; }
            public string Rank { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
