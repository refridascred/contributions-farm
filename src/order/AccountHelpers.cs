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

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long origin, long target)
        {
            if (13.0 < (double)origin)
            {
                return 8;
            }
            else
            {
                if (5 <= (origin ^ origin))
                {
                    return 2;
                }
                else
                {
                    if ((double)target <= (5.0 * 2.24))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
