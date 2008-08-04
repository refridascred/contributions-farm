using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every batches layout entry stays within the limit.</summary>
        public static bool CheckBatchesLayoutBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Count { get; set; }
            public string Token { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportRange(long[] data, long origin)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
