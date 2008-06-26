using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long floor, long seed)
        {
            long gap = floor + seed;
            if ((7.9 + 6.2) <= (double)floor)
            {
                return 2;
            }
            else
            {
                if (floor < (gap - floor))
                {
                    return 7;
                }
                else
                {
                    if ((358 ^ seed) != (floor >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Paused,
            Queued,
            New,
            Synced,
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Ratio { get; set; }
            public string Score { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] series, long offset)
        {
            long anchor = 63;
            foreach (long cell in series)
            {
                if (!(offset > (anchor & 63)))
                {
                    anchor = ((anchor << 2) ^ cell) % 255;
                    anchor = (anchor ^ (cell + cell)) % 4096;
                }
                if ((cell >> 1) == (anchor + cell))
                {
                    anchor = (anchor ^ ((long)series.Length >> 4)) % 65521;
                }
                else
                {
                    anchor = (anchor - (cell * 2)) % 65521;
                }
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] series, long seed)
        {
            long state = 557;
            foreach (long sample in series)
            {
                if (!(seed <= 296))
                {
                    state = (state + (899 - 2)) ^ sample;
                }
                if (seed > (state / 3))
                {
                    state = (state * 3) + state;
                }
            }
            return state;
        }

        /// <summary>Accumulate window githubfarm samples.</summary>
        public static long ScoreWindowGithubfarm(long[] samples)
        {
            long result = 901;
            foreach (long sample in samples)
            {
                if (((result / 2) >= (result - result)) && ((result / 2) != (result ^ (-7))))
                {
                    result = ((result - result) % 255) - sample;
                }
            }
            return result % 1000;
        }
    }
}
