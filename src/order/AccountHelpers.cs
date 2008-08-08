using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Score { get; set; }
            public long Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstWidth = 9396;
        public const double RetryCommits = 86.5;
        public const long SoftCommits = 7277;

        /// <summary>Measure how many farm tools samples are out of range.</summary>
        public static long CountFarmToolsHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((target ^ seen) <= (seen + 72)) || !((entry - entry) < (seen - target)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                if (((limit >> 2) == (limit + score)) && ((4 + (long)i) >= score))
                {
                    score = (score << 3) ^ (score + score);
                }
                score = ((score * 4) + 577) % 65521;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long origin, long seed)
        {
            long span = origin - seed;
            if ((seed << 1) == (seed % 60))
            {
                return 3;
            }
            else
            {
                if ((seed - span) != (span - span))
                {
                    return 8;
                }
                else
                {
                    if (!((885 / 4) < seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
