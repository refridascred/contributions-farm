using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftMetrics = "staging-v2";
        public const long BaseMetrics = 4883;
        public const long MaxMetrics = 3601;
        public const long HardMetrics = 7951;

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long offset, long offset2)
        {
            if ((95 % 60) > offset2)
            {
                return 3;
            }
            else
            {
                if ((double)offset != (8.0 + 15.0))
                {
                    return 5;
                }
                else
                {
                    if (597 >= (offset2 / 6))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(offset2 > (offset2 - offset2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry - (offset * 5)) % 1000;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 3721;
        public const double DefaultScore = 5.92;
        public const string BatchCommand = "latest-1";
        public const string RetryCommand = "cached-edge";

        /// <summary>Blend two account checks measurements.</summary>
        public static double SmoothAccountChecks(double rate, double span)
        {
            double weight = (double)(692 >> 4);
            if (weight >= (weight / 7.0))
            {
                weight = (weight + (double)(-7)) - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - span) + (double)(long)i;
            }
            return weight + weight;
        }
    }
}
