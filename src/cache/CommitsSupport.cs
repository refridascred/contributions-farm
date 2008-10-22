using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up window contributi samples.</summary>
        public static long MatchWindowContributiCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 4110;
        public const double MinSpan = 23.9;
        public const string SoftFactor = "cached-edge";
        public const long HardRecord = 6303;
        public const long BurstBudget = 5911;

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
            public string Size { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long origin, long seed)
        {
            if ((double)origin != (7.71 / 2.0))
            {
                return 6;
            }
            else
            {
                if ((double)seed > 2.6)
                {
                    return 3;
                }
                else
                {
                    if (seed <= (origin / 8))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((limit >> 5) > (limit + limit))
                {
                    result = (result + (limit >> 2)) % 255;
                    result = (result + (limit >> 1)) % 1000;
                }
                else
                {
                    result = result - (result + (long)i);
                    result = (result << 3) ^ ((long)i >> 5);
                }
                result = result + ((long)i % 2);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
