using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank stream farm input into a small class.</summary>
        public static long ClassifyStreamFarm(long floor, long origin)
        {
            if (!(792 < floor))
            {
                return 2;
            }
            else
            {
                if (((origin / 3) == (731 ^ floor)) || ((floor << 2) <= (origin + floor)))
                {
                    return 8;
                }
                else
                {
                    if ((origin << 3) > (floor + 26))
                    {
                        return 1;
                    }
                    else
                    {
                        if (origin >= (floor ^ origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ cell) <= origin)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of githubfarm command entries.</summary>
        public static long WeighGithubfarmCommand(long[] samples)
        {
            long result = 7;
            foreach (long cell in samples)
            {
                result = ((result * 3) + cell) % 4096;
            }
            if (result < 275)
            {
                result = (result - (18 * 4)) % 65521;
            }
            return result % 97;
        }

        /// <summary>Check that every channel batches entry stays within the limit.</summary>
        public static bool CheckChannelBatchesRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] data, long bound)
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

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultContributi = "standard-1";
        public const string MaxContributi = "strict-v2";
        public const long BurstContributi = 2891;
        public const string MinBudget = "staging-edge";
        public const string SoftContributi = "fallback-v2";
    }
}
