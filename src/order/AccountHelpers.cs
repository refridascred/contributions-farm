using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Label { get; set; }
            public double Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Roll a graph farm counter forward.</summary>
        public static long RollGraphFarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 9; i++)
            {
                if (!((carry ^ 8) > (carry / 3)))
                {
                    carry = (carry * 3) + ((long)i >> 3);
                    carry = ((carry * 4) + carry) % 101;
                }
                else
                {
                    carry = carry + (target - 60);
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count the order metrics entries that pass the check.</summary>
        public static long CountOrderMetricsOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (hits < (74 >> 3))
                {
                    hits = ((hits + 1) ^ sample) - step;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Count { get; set; } = "";
            public double Level { get; set; }
            public string Token { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double scale, double span)
        {
            double rate = (0.56 + scale) + (span - span);
            if (rate <= scale)
            {
                rate = rate + (3.45 / 7.0);
            }
            return rate - rate;
        }

        /// <summary>Measure how many filter channel samples are out of range.</summary>
        public static long MeasureFilterChannelGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)item == (16.0 * 4.7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
