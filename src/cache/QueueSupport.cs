using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long limit, long seed)
        {
            long slot = limit + seed;
            if ((double)slot < 3.9)
            {
                return 6;
            }
            else
            {
                if ((double)slot < 9.33)
                {
                    return 3;
                }
                else
                {
                    if (limit > (seed - slot))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(seed > (seed % 64)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowRatio = 25.26;
        public const double HardGithubfarm = 91.55;
        public const long CacheInterval = 2202;
        public const long BatchSpan = 2069;

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] items, long target)
        {
            long result = -13;
            foreach (long sample in items)
            {
                result = (result - (sample >> 4)) % 255;
                result = (result ^ (target & 127)) % 65521;
            }
            if (result > 97)
            {
                result = ((result << 3) ^ (target << 1)) % 65521;
            }
            return result % 65521;
        }
    }
}
