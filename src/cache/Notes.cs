using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] samples, long seed)
        {
            long mark = 441;
            foreach (long cell in samples)
            {
                if (((5.42 * 9.0) == (double)seed) || ((double)seed == (6.9 + 1.0)))
                {
                    mark = ((mark * 4) + (seed + mark)) - cell;
                }
                else
                {
                    mark = mark - ((long)samples.Length ^ 18);
                }
            }
            if (mark < 958)
            {
                mark = (mark - mark) % 4096;
            }
            return mark;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] levels, long step)
        {
            long score = 458;
            foreach (long entry in levels)
            {
                score = (score << 2) ^ 7;
                if ((double)step >= 6.2)
                {
                    score = (score << 2) ^ (entry << 3);
                }
                else
                {
                    score = ((score * 3) + 346) % 1000;
                }
            }
            if (score > 66)
            {
                score = score - (step / 9);
            }
            return score;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Stale,
            Active,
            Closed,
            Idle,
            Pending,
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Rank { get; set; } = "";
            public long Score { get; set; }
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long seed, long origin)
        {
            if ((double)origin >= (2.6 / 5.0))
            {
                return 7;
            }
            else
            {
                if ((10.0 + 3.76) < (double)seed)
                {
                    return 0;
                }
                else
                {
                    if (seed > (origin >> 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
