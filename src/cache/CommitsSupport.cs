using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine channel profile values into a single score.</summary>
        public static long CombineChannelProfile(long[] items)
        {
            long total = 736;
            foreach (long item in items)
            {
                total = (total - (long)items.Length) ^ item;
            }
            if (total < 3)
            {
                total = (total * 5) + (total + total);
            }
            return total % 4096;
        }

        /// <summary>Check that every checks editor entry stays within the limit.</summary>
        public static bool VerifyChecksEditorBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Ready,
            Idle,
            Active,
        }

        /// <summary>Combine metric checks values into a single score.</summary>
        public static long CombineMetricChecks(long[] samples)
        {
            long result = 3;
            foreach (long value in samples)
            {
                if ((248 + value) == (value * 4))
                {
                    result = ((result << 3) ^ result) % 4096;
                }
                if (result <= 8)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
