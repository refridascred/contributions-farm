using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a counter profile pair into a bucket.</summary>
        public static long BucketCounterProfile(long floor, long offset)
        {
            if ((offset <= (offset - floor)) || ((offset * 5) < (-19)))
            {
                return 0;
            }
            else
            {
                if (((double)offset >= 4.7) || ((floor & 63) > (offset / 4)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 3859;
        public const double WindowRatio = 12.56;
        public const long LimitTimeout = 9904;
        public const long BatchScore = 2955;

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double bias, double floor)
        {
            double load = (double)31 + (bias + bias);
            return (load + 9.8) + floor;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate order format readings against a bound.</summary>
        public static bool CheckOrderFormatLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank githubfarm queue input into a small class.</summary>
        public static long BucketGithubfarmQueue(long floor, long limit)
        {
            long diff = floor ^ limit;
            if ((limit % 3) != (444 / 5))
            {
                return 0;
            }
            else
            {
                if (!((6.13 - 6.0) <= (double)diff))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
