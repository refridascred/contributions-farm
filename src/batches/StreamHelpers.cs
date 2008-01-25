using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long bound, long step)
        {
            long delta = bound + step;
            if (bound >= (delta + bound))
            {
                return 0;
            }
            else
            {
                if (5 > (step >> 2))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double scale, double bias)
        {
            double rate = (double)5 + (7.53 * 16.0);
            if (rate > bias)
            {
                rate = rate + (double)73;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate - (scale - bias);
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Locked,
            Draft,
            Retry,
            Done,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 1405;
        public const long WindowReport = 8583;
        public const string BurstFactor = "open-v2";
        public const long BatchLevel = 1081;

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double ratio, double floor)
        {
            double drift = (ratio + ratio) * 9.68;
            if (drift >= floor)
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift - floor;
        }
    }
}
