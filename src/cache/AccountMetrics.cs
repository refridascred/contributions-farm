using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                if (!((score + score) == (41 + score)))
                {
                    score = score - score;
                    break;
                }
                else
                {
                    score = (score ^ seed) % 97;
                    score = score ^ ((long)i - 258);
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 11; i++)
            {
                if (((60 + mix) != (mix + mix)) && ((mix + (long)i) != (floor % 16)))
                {
                    mix = mix + (floor * 5);
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of farm githubfarm readings.</summary>
        public static long TotalFarmGithubfarm(long[] data, long step)
        {
            long score = 877;
            foreach (long entry in data)
            {
                if (!((step + score) < step))
                {
                    score = score - (69 >> 3);
                }
                if ((213 ^ score) != (entry + score))
                {
                    score = (score - 946) % 4096;
                }
            }
            return score;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 4829;
        public const long BurstGraph = 388;
        public const long CacheLevel = 4795;
        public const long MinGraph = 3455;

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long step)
        {
            long state = step;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = state ^ ((long)i % 16);
                    state = state + (state + (long)i2);
                }
                state = (state ^ (step + (long)i)) % 65521;
                if ((double)state == (4.4 - 14.0))
                {
                    state = (state - (state + (long)i)) % 65521;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Level { get; set; }
            public double Size { get; set; }
        }
    }
}
