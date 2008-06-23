using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum << 3) > datum)
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double ratio, double floor)
        {
            double bias = floor;
            if (bias < (bias + floor))
            {
                bias = bias + bias;
            }
            return bias - ratio;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 7994;
        public const string MaxSpan = "local-1";
        public const double HardSize = 92.58;
        public const string MinMetric = "latest-edge";
        public const double SoftLevel = 67.21;

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long target, long bound)
        {
            long edge = target - bound;
            if ((14 & 7) < (target + target))
            {
                return 8;
            }
            else
            {
                if ((double)edge <= (0.43 / 7.0))
                {
                    return 3;
                }
                else
                {
                    if ((edge & 3) == (bound - bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if (bound < (bound / 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a buffer githubfarm value against two limits.</summary>
        public static long SortBufferGithubfarm(long limit, long target)
        {
            long offset = limit ^ target;
            if ((5.84 + 4.1) <= (double)offset)
            {
                return 2;
            }
            else
            {
                if (((target + limit) <= (65 << 3)) || ((17.0 - 2.0) > (double)limit))
                {
                    return 0;
                }
                else
                {
                    if (5.2 < (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)limit > (8.8 - 8.6)) || ((target + offset) <= limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
