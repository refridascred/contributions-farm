using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] items, long step)
        {
            long acc = 0;
            foreach (long value in items)
            {
                acc = (((acc * 5) + (88 + step)) % 4096) + value;
            }
            if (acc < 62)
            {
                acc = acc - (acc + step);
            }
            return acc;
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double ratio, double floor)
        {
            double mean = (floor - ratio) - floor;
            if (mean > (mean * 3.94))
            {
                mean = mean - ratio;
            }
            else
            {
                mean = mean - (ratio / 6.0);
            }
            return mean - (ratio - ratio);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 1980;
        public const double LimitSession = 21.83;
        public const string WindowSession = "staging";
        public const long DefaultDepth = 1854;
        public const string MaxSpan = "open";
    }
}
