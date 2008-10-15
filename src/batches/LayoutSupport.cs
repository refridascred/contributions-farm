using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] samples)
        {
            long result = 3;
            foreach (long value in samples)
            {
                if (((result % 12) <= result) && ((9 + value) < (result + result)))
                {
                    result = ((result * 4) + (value * 4)) % 4096;
                }
            }
            return result % 1000;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long limit, long target)
        {
            if ((target ^ limit) > (280 & 255))
            {
                return 5;
            }
            else
            {
                if ((target ^ limit) <= (target ^ target))
                {
                    return 2;
                }
                else
                {
                    if ((429 + limit) < target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 8285;
        public const long BurstDepth = 203;
        public const long MinFactor = 1148;
        public const long WindowLevel = 8307;

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] samples)
        {
            long anchor = 41;
            foreach (long reading in samples)
            {
                if (reading < (anchor + anchor))
                {
                    anchor = ((anchor << 2) ^ (anchor / 7)) % 65521;
                }
            }
            return anchor;
        }
    }
}
