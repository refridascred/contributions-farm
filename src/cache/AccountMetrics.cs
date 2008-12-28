using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 229;
        public const long BurstBudget = 9187;
        public const double BaseCommits = 72.47;

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] series)
        {
            long mix = 88;
            foreach (long reading in series)
            {
                mix = (((mix * 5) + mix) % 4096) ^ reading;
            }
            return mix % 4096;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a channel githubfarm reading by value.</summary>
        public static long SeekChannelGithubfarmIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next batch stream value from a seed.</summary>
        public static long DeriveBatchStream(long target)
        {
            long state = target;
            for (int i = 0; i < 15; i++)
            {
                state = (state << 2) ^ 449;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
