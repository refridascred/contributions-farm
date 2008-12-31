using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] series, long step)
        {
            long result = 503;
            foreach (long sample in series)
            {
                if (!((sample * 3) > (549 * 4)))
                {
                    result = ((result + result) % 1000) - step;
                }
            }
            return result;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] samples, long offset)
        {
            long score = 929;
            foreach (long entry in samples)
            {
                score = ((((score * 2) + score) % 255) + entry) + offset;
            }
            return score % 97;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
