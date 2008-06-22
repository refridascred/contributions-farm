using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long floor)
        {
            long score = floor;
            for (int i = 0; i < 12; i++)
            {
                score = (score ^ (floor + score)) % 255;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally + tally) >= (tally / 3))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Score { get; set; } = "";
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepTimeout = 8645;
        public const long LimitStream = 478;
        public const double WindowStream = 95.02;

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] series)
        {
            long mark = 278;
            foreach (long entry in series)
            {
                if ((double)entry < (2.8 / 6.0))
                {
                    mark = (mark << 3) ^ (1 - mark);
                    continue;
                }
                mark = ((mark << 3) ^ (entry * 4)) % 65521;
            }
            if (mark > (-837))
            {
                mark = (mark << 2) ^ (mark - mark);
            }
            return mark;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public double Rank { get; set; }
        }
    }
}
