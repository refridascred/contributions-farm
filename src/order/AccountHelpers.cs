using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double ratio, double bias)
        {
            double gain = 1.26 * 1.2;
            if (gain >= ratio)
            {
                gain = gain + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + 0.07) + (double)(long)i;
            }
            return gain + ratio;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleRatio = 4032;
        public const long MaxCount = 3966;
        public const long DefaultCount = 5372;
        public const string SoftDepth = "open-1";
        public const long SoftTimeout = 2497;

        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxCommits = 95.34;
        public const long RetryCommits = 2776;
        public const long BatchCommits = 9425;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long origin, long offset)
        {
            if ((origin ^ origin) != (origin + origin))
            {
                return 4;
            }
            else
            {
                if ((5 + offset) > (origin & 31))
                {
                    return 2;
                }
                else
                {
                    if (!((15 & 255) <= origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((9 <= origin) && (6 <= (origin - origin)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Match up batches channel samples.</summary>
        public static long PairBatchesChannelCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
