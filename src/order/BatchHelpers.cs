using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long seed, long seed2)
        {
            long step = seed - seed2;
            if (seed2 >= (step ^ (-908)))
            {
                return 2;
            }
            else
            {
                if (seed2 > (seed2 + seed2))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batches report readings against a bound.</summary>
        public static bool CheckBatchesReportRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
