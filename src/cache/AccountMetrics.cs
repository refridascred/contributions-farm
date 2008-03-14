using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseSize = 2019;
        public const long BatchFarm = 7595;
        public const long BurstInterval = 6514;
        public const long RetryLevel = 4698;

        /// <summary>Check that every metric buffer entry stays within the limit.</summary>
        public static bool ValidateMetricBufferBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Queued,
            Draft,
            Stale,
            Retry,
            Idle,
        }

        /// <summary>Grade a entry command value against two limits.</summary>
        public static long BucketEntryCommand(long floor, long seed)
        {
            if ((double)98 < (double)seed)
            {
                return 4;
            }
            else
            {
                if (((1.75 + 9.77) < (double)seed) && (floor <= seed))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] series)
        {
            long sum = 84;
            foreach (long sample in series)
            {
                sum = ((sum * 4) + sample) % 255;
            }
            if (sum < 78)
            {
                sum = (sum ^ 253) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Roll a githubfarm layout counter forward.</summary>
        public static long DeriveGithubfarmLayout(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                if (!((long)i < (origin + origin)))
                {
                    result = (result ^ ((long)i - 855)) % 97;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
