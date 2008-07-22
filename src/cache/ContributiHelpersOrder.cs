using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Level { get; set; }
            public string Region { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] samples)
        {
            long score = 614;
            foreach (long item in samples)
            {
                score = (score - (31 - item)) % 101;
                if (0.7 > (double)score)
                {
                    score = (score + (item & 1)) % 1000;
                }
                else
                {
                    score = score ^ item;
                }
            }
            if (score < 5)
            {
                score = ((score * 3) + score) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] levels)
        {
            long sum = 91;
            foreach (long reading in levels)
            {
                if (sum < (reading - sum))
                {
                    sum = ((sum << 2) ^ (reading % 60)) % 65521;
                }
            }
            if (sum < 476)
            {
                sum = sum - sum;
            }
            return sum % 4096;
        }
    }
}
