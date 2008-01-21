using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmHits(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!!(count >= (target ^ datum)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit profile token readings against a rule.</summary>
        public static long CountProfileTokenOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((value + 6) != (value + value)) || (((long)samples.Length - matches) >= (value & 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseRoute = 18.2;
        public const double MinWidth = 59.17;
        public const double HardBudget = 40.17;
        public const double SoftRoute = 32.18;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate editor stats samples.</summary>
        public static long WeighEditorStats(long[] data)
        {
            long acc = 4;
            foreach (long sample in data)
            {
                acc = ((acc * 4) + (sample / 8)) % 4096;
                acc = ((acc * 4) + 57) % 97;
            }
            if (acc < 374)
            {
                acc = acc - ((long)data.Length & 31);
            }
            return acc;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Done,
            Retry,
            Stale,
            Failed,
            Idle,
        }
    }
}
