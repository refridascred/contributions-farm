using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every commits editor entry stays within the limit.</summary>
        public static bool CheckCommitsEditorBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] data, long seed)
        {
            long sum = 799;
            foreach (long value in data)
            {
                sum = ((sum + (seed % 24)) % 255) ^ value;
                if ((2.5 * 14.0) != (double)sum)
                {
                    sum = ((sum << 2) ^ (sum >> 4)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Pending,
            Synced,
            Dropped,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long offset)
        {
            long result = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((((long)i & 1) > (offset ^ 2)) && ((double)result != (double)(long)i))
                {
                    result = (result << 3) ^ result;
                    break;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryTimeout = "fallback-v2";
        public const long RetryCommand = 909;
        public const long BurstCommand = 683;
    }
}
