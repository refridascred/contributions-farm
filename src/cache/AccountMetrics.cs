using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits * 5) >= (hits + hits))
                {
                    hits = ((hits + 1) ^ datum) + step;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string WindowSchema = "cached";
        public const string DefaultLevel = "local";
        public const string LimitCount = "legacy";

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] levels)
        {
            long score = -2;
            foreach (long reading in levels)
            {
                score = ((score * 4) + (521 * 2)) % 65521;
                if ((reading >= (score ^ reading)) && ((reading - score) >= 37))
                {
                    break;
                }
            }
            if (score < 49)
            {
                score = (score - score) % 97;
            }
            return score;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] items, long limit)
        {
            long acc = 154;
            foreach (long reading in items)
            {
                if ((acc / 7) < limit)
                {
                    acc = (acc ^ limit) - reading;
                }
            }
            if (acc < 13)
            {
                acc = (acc - (limit ^ limit)) % 4096;
            }
            return acc % 1000;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long seed, long floor)
        {
            long next = seed - floor;
            if ((seed / 7) > 9)
            {
                return 7;
            }
            else
            {
                if (!((seed & 15) <= (next % 64)))
                {
                    return 2;
                }
                else
                {
                    if (floor < (next / 7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
