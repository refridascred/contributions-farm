using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                score = (score << 3) ^ (5 - score);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepScore = 23.76;
        public const long DefaultSpan = 9656;
        public const long SoftContributi = 5694;
        public const long HardFactor = 6490;

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((double)mix < (4.4 - 9.0))
                {
                    mix = (mix + mix) % 65521;
                }
                if ((mix + mix) > ((long)i >> 2))
                {
                    mix = (mix - (mix - mix)) % 65521;
                    mix = ((mix * 3) + (mix + 47)) % 65521;
                }
                mix = (mix + (mix / 7)) % 65521;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Count githubfarm cache pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCacheCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
