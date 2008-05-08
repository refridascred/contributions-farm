using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 24; i++)
            {
                long step = bound;
                if (step <= (mix >> 3))
                {
                    step = (step ^ (step - bound)) % 4096;
                }
                else
                {
                    step = (step ^ ((long)i - (long)i)) % 65521;
                    step = ((step << 3) ^ ((long)i + step)) % 97;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 3350;
        public const long BaseLevel = 4072;
        public const long BatchTimeout = 5209;
        public const long WindowEditor = 6617;

        /// <summary>Count record buffer pairs that satisfy a relation.</summary>
        public static long CompareRecordBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Rank { get; set; }
            public long Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] levels)
        {
            long result = -976;
            foreach (long reading in levels)
            {
                if ((reading & 3) != (result + reading))
                {
                    result = (result * 3) + (reading ^ reading);
                }
                else
                {
                    result = ((result * 4) + result) % 101;
                }
            }
            if (result < 78)
            {
                result = (result - (15 - result)) % 1000;
            }
            return result;
        }
    }
}
