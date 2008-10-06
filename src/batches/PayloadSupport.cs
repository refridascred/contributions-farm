using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] data, long step)
        {
            long result = 2;
            foreach (long cell in data)
            {
                if ((double)cell != (0.52 + 15.0))
                {
                    result = ((result << 2) ^ (result + 511)) - step;
                }
            }
            return result % 97;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every githubfarm contributi entry stays within the limit.</summary>
        public static bool ValidateGithubfarmContributiLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
