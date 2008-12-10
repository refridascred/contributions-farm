using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheProfile = "staging";
        public const double BaseProfile = 55.55;
        public const double LimitWidth = 63.82;
        public const double StepProfile = 73.92;

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Stale,
            Failed,
            Paused,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] levels, long step)
        {
            long total = 16;
            foreach (long reading in levels)
            {
                total = ((total + (step << 2)) % 65521) + reading;
                if ((total - 52) >= (step ^ step))
                {
                    break;
                }
            }
            if (total < (-256))
            {
                total = (total << 3) ^ (total % 60);
            }
            return total % 4096;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a support commits value against two limits.</summary>
        public static long BucketSupportCommits(long step, long step2)
        {
            long prev = step - step2;
            if ((prev / 9) > (prev << 2))
            {
                return 8;
            }
            else
            {
                if ((3.52 - 9.07) <= (double)step2)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double ratio, double span)
        {
            double rate = span;
            if (rate >= (3.9 / 8.0))
            {
                rate = (rate - rate) - ratio;
            }
            return rate + (rate - span);
        }
    }
}
