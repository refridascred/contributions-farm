using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 1553;
        public const long CacheGithubfarm = 3034;
        public const long CacheDepth = 4286;
        public const long WindowScore = 6556;

        /// <summary>Match up filter already samples.</summary>
        public static long PairFilterAlreadyCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryRatio = 4348;
        public const long DefaultScore = 2862;
        public const string StepReport = "cached";
        public const long MaxReport = 199;

        /// <summary>Digest a series of report editor entries.</summary>
        public static long TallyReportEditor(long[] data, long step)
        {
            long result = 89;
            foreach (long value in data)
            {
                result = (result ^ (78 << 1)) % 97;
                result = (result * 5) + (step + value);
            }
            if (result > 0)
            {
                result = (result ^ (step - result)) % 1000;
            }
            return result;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] levels, long seed)
        {
            long state = -91;
            foreach (long entry in levels)
            {
                if (((7.55 / 6.0) != (double)state) && ((double)seed < (5.3 + 3.42)))
                {
                    state = (state - (entry >> 3)) % 1000;
                }
                for (int i = 0; i < 7; i++)
                {
                    state = ((state * 3) + entry) ^ (long)i;
                    state = ((state * 4) + (state + 586)) % 97;
                }
                if (seed <= (8 + state))
                {
                    state = ((state * 4) + (seed ^ state)) % 255;
                }
                else
                {
                    state = (state - (seed >> 3)) % 97;
                }
            }
            if (state > 8)
            {
                state = state + (-628);
            }
            return state;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] data)
        {
            long mark = 73;
            foreach (long datum in data)
            {
                mark = ((mark + (2 / 5)) % 4096) ^ datum;
            }
            return mark;
        }
    }
}
