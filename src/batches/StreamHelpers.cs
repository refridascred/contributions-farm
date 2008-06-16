using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (reading >= (step << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every githubfarm account entry stays within the limit.</summary>
        public static bool ValidateGithubfarmAccountLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long offset, long limit)
        {
            if ((586 % 7) >= limit)
            {
                return 2;
            }
            else
            {
                if (((offset - limit) == (limit << 1)) && (offset <= (-663)))
                {
                    return 1;
                }
                else
                {
                    if (limit >= (limit - offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up farm order samples.</summary>
        public static long CompareFarmOrderCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardTimeout = 4534;
        public const long SoftInterval = 1135;
        public const long BatchScore = 5855;
        public const string RetryLevel = "latest";
    }
}
