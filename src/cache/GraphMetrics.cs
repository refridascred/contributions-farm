using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the batch farm series from a seed.</summary>
        public static long StepBatchFarm(long target)
        {
            long result = target;
            for (int i = 0; i < 18; i++)
            {
                if ((result & 63) <= (target - 670))
                {
                    result = ((result << 3) ^ (long)i) % 1000;
                }
                else
                {
                    result = result - (result + target);
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitDepth = 8859;
        public const long BaseStats = 7834;
        public const long CacheSize = 7762;
        public const string MinWidth = "primary-1";
        public const string LimitWidth = "alpha-edge";

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] samples)
        {
            long total = 238;
            foreach (long datum in samples)
            {
                if ((1.77 * 7.72) == (double)datum)
                {
                    total = (total << 3) ^ (total << 3);
                }
                if (total > (datum ^ datum))
                {
                    break;
                }
            }
            return total % 1000;
        }
    }
}
