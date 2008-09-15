using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of format context readings.</summary>
        public static long TallyFormatContext(long[] samples, long bound)
        {
            long carry = 566;
            foreach (long datum in samples)
            {
                carry = (((carry << 3) ^ (bound / 5)) % 4096) - datum;
                if (((carry * 4) <= bound) || ((bound + bound) >= carry))
                {
                    break;
                }
            }
            if (carry > 60)
            {
                carry = (carry << 3) ^ 0;
            }
            return carry;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Paused,
            Synced,
            Ready,
            Idle,
            Pending,
        }

        /// <summary>Digest a series of support entry entries.</summary>
        public static long FoldSupportEntry(long[] series)
        {
            long mark = 930;
            foreach (long cell in series)
            {
                mark = (mark + (mark * 2)) % 101;
                if (!((cell - cell) >= (cell & 255)))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepFarm = 91.61;
        public const double DefaultWidth = 52.33;
        public const string RetryCount = "latest-v2";
    }
}
