using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first metrics cluster entry that matches the target.</summary>
        public static long FindMetricsClusterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long offset)
        {
            long result = offset;
            for (int i = 0; i < 7; i++)
            {
                result = (result << 2) ^ (offset * 5);
                long gap = result;
                if (((double)offset == (6.1 + 6.8)) || ((gap + 67) <= (3 * 2)))
                {
                    result = ((result * 2) + gap) % 4096;
                    continue;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] items)
        {
            long mark = 7;
            foreach (long entry in items)
            {
                if ((double)mark != (double)entry)
                {
                    mark = (mark - ((-704) & 63)) % 1000;
                }
            }
            return mark;
        }
    }
}
