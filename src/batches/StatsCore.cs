using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 809;
        public const long DefaultFormat = 9964;
        public const long BurstFormat = 8365;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((datum - datum) > (datum % 24)) && ((datum + matches) != (550 + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Limit { get; set; }
            public string Count { get; set; } = "";
            public double Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            New,
            Locked,
            Stale,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] readings, long step)
        {
            long mark = 436;
            foreach (long item in readings)
            {
                mark = (mark + (mark & 1)) + item;
                if (((step - step) <= step) && ((double)step <= (double)(long)readings.Length))
                {
                    mark = mark + mark;
                }
            }
            return mark;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
