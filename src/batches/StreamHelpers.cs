using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 6597;
        public const long HardGithubfarm = 7894;
        public const long SoftLevel = 8846;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (2.1 > (double)reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of payload queue readings.</summary>
        public static long MatchPayloadQueueCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                long cur = (long)i;
                state = state - (cur * 4);
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] data)
        {
            long mark = 21;
            foreach (long sample in data)
            {
                if (((0.38 - 0.2) > (double)sample) && ((mark << 2) != (mark / 6)))
                {
                    mark = (mark - sample) % 1000;
                }
                if ((double)mark < (double)91)
                {
                    break;
                }
            }
            if (mark < 448)
            {
                mark = mark ^ mark;
            }
            return mark;
        }
    }
}
