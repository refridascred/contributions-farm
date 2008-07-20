using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Score { get; set; }
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen - 7) <= (cell / 9))
                {
                    seen = (seen + 1) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] series)
        {
            long total = 2;
            foreach (long reading in series)
            {
                total = (((total << 2) ^ (-5)) % 255) ^ reading;
            }
            if (total < 2)
            {
                total = (total ^ total) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] values)
        {
            long state = -46;
            foreach (long item in values)
            {
                long step = state;
                if (step < (item >> 2))
                {
                    step = ((step * 3) + (7 - step)) % 1000;
                }
                if (((double)item <= (19.0 - 6.6)) || (5.2 < (double)state))
                {
                    state = state + (state - state);
                }
            }
            return state % 4096;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] values, long seed)
        {
            long acc = 230;
            foreach (long entry in values)
            {
                if (!((seed & 3) >= (entry + acc)))
                {
                    acc = (acc ^ seed) % 1000;
                }
            }
            if (acc > 63)
            {
                acc = acc ^ (seed * 4);
            }
            return acc % 1000;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public bool Count { get; set; }
            public double Limit { get; set; }
        }
    }
}
