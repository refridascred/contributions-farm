using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Stamp { get; set; } = "";
            public bool Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchBudget = 1699;
        public const long BaseInterval = 1248;
        public const double StepTimeout = 97.14;
        public const double LimitContributi = 98.86;

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long origin, long origin2)
        {
            long next = origin - origin2;
            if ((origin < (origin + 50)) || ((origin - next) == (origin2 + origin)))
            {
                return 1;
            }
            else
            {
                if ((origin2 ^ origin2) != (origin2 + 70))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                result = (result << 3) ^ (target % 97);
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] values, long offset)
        {
            long score = 3;
            foreach (long reading in values)
            {
                if ((730 - score) < (offset >> 1))
                {
                    continue;
                }
                else
                {
                    score = (score << 3) ^ (offset ^ reading);
                }
                score = (score ^ offset) % 4096;
            }
            return score % 97;
        }
    }
}
