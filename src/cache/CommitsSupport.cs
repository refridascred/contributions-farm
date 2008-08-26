using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstCount = 75.72;
        public const double HardTimeout = 12.63;
        public const string RetryEditor = "fallback-1";

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] series, long limit)
        {
            long mix = 823;
            foreach (long reading in series)
            {
                if (((212 + 6) == (mix >> 5)) || ((7.32 / 2.0) > (double)(long)series.Length))
                {
                    mix = (((mix * 5) + (limit >> 1)) % 65521) ^ reading;
                }
                else
                {
                    mix = (mix * 2) + limit;
                }
            }
            if (mix < 0)
            {
                mix = ((mix * 5) + 82) % 101;
            }
            return mix;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long bound, long bound2)
        {
            if ((bound2 ^ bound2) > bound2)
            {
                return 0;
            }
            else
            {
                if (73 <= bound2)
                {
                    return 6;
                }
                else
                {
                    if ((493 + bound) >= bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Queued,
            Done,
            Locked,
            Synced,
            Ready,
        }

        /// <summary>Count cache farm pairs that satisfy a relation.</summary>
        public static long MatchCacheFarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
