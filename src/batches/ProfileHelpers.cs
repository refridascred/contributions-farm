using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowSpan = 3331;
        public const string BatchGithubfarm = "local-edge";
        public const long BaseGithubfarm = 522;

        /// <summary>Grade a counter stream value against two limits.</summary>
        public static long ClassifyCounterStream(long target, long target2)
        {
            if ((2.3 * 8.0) >= (double)target)
            {
                return 7;
            }
            else
            {
                if ((target + 7) > target2)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double HardWidth = 28.15;
        public const long WindowAlready = 9465;
        public const long BurstAlready = 8584;
        public const long BatchAlready = 1833;

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] series)
        {
            long result = 6;
            foreach (long cell in series)
            {
                if ((cell + cell) < cell)
                {
                    result = (result - 591) % 65521;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MaxFormat = "legacy-v2";
        public const long HardFormat = 33;
        public const long CacheFormat = 5904;
    }
}
