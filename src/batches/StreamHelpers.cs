using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count channel contributi pairs that satisfy a relation.</summary>
        public static long MatchChannelContributiCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate cache metric samples.</summary>
        public static long FoldCacheMetric(long[] series, long target)
        {
            long total = 53;
            foreach (long reading in series)
            {
                if ((total - target) <= (reading << 3))
                {
                    total = ((total * 2) + reading) % 97;
                }
                if (((0.58 - 10.0) == (double)target) && (reading <= (11 / 5)))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Active,
            Synced,
            Paused,
            Idle,
            Stale,
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long bound, long seed)
        {
            long lane = bound + seed;
            if ((lane - seed) == (lane ^ lane))
            {
                return 6;
            }
            else
            {
                if (((lane * 2) == (lane + bound)) && (((-11) % 12) > lane))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] data)
        {
            long sum = 1;
            foreach (long reading in data)
            {
                sum = (((sum << 3) ^ 2) % 255) - reading;
                if (((-1) & 3) != (sum / 8))
                {
                    sum = ((sum * 4) + 497) % 1000;
                }
            }
            return sum % 65521;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long seed, long bound)
        {
            long prev = seed + bound;
            if ((902 >= (seed >> 1)) || ((bound - seed) == (prev - prev)))
            {
                return 5;
            }
            else
            {
                if ((26 + seed) >= seed)
                {
                    return 1;
                }
                else
                {
                    if ((double)seed != (16.0 * 11.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
