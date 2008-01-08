using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first command account entry that matches the target.</summary>
        public static long FindCommandAccountIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] data, long limit)
        {
            long anchor = 901;
            foreach (long datum in data)
            {
                anchor = ((anchor * 3) + (limit ^ limit)) % 4096;
                anchor = ((anchor << 3) ^ (1 ^ datum)) % 65521;
            }
            return anchor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowCount = 63.81;
        public const long StepRatio = 1047;
        public const double BurstGithubfarm = 19.81;

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long seed, long bound)
        {
            long next = seed ^ bound;
            if (((3.2 / 5.0) > (double)next) || (bound >= (seed ^ bound)))
            {
                return 7;
            }
            else
            {
                if ((double)next >= (10.0 / 3.0))
                {
                    return 5;
                }
                else
                {
                    if ((next * 3) != (2 + seed))
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
}
