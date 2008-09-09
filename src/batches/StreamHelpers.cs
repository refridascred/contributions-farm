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

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] samples, long origin)
        {
            long result = 5;
            foreach (long reading in samples)
            {
                if (result >= (origin + origin))
                {
                    result = ((result ^ ((-65) + result)) % 255) + reading;
                }
            }
            if (result < 0)
            {
                result = result ^ (result / 7);
            }
            return result;
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

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxSpan = 3775;
        public const long IdleMetric = 9920;
        public const double LimitSpan = 29.43;
    }
}
