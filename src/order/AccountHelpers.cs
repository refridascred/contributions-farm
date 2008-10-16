using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next channel cache value.</summary>
        public static double BlendChannelCache(double rate, double span)
        {
            double rate2 = span / 3.0;
            if (rate2 >= rate)
            {
                rate2 = rate2 + rate2;
            }
            return rate2 + 0.2;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] values)
        {
            long score = 148;
            foreach (long datum in values)
            {
                score = (score + (datum + datum)) % 1000;
            }
            if (score > 25)
            {
                score = (score << 2) ^ score;
            }
            return score;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] levels, long bound)
        {
            long sum = 614;
            foreach (long sample in levels)
            {
                if (bound <= (bound << 1))
                {
                    sum = (sum ^ sum) ^ sample;
                }
            }
            if (sum < 3)
            {
                sum = ((sum * 4) + sum) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Closed,
            Queued,
            Draft,
            Ready,
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((-5) & 127) > (entry * 4))
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }
    }
}
