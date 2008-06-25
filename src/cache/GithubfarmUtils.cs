using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Idle,
            New,
            Pending,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 2440;
        public const string LimitContributi = "alpha-edge";
        public const long MaxRatio = 8132;
        public const long SoftContributi = 8536;

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry << 3) ^ (floor % 24)) % 101;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Classify a order notes pair into a bucket.</summary>
        public static long BucketOrderNotes(long step, long floor)
        {
            if ((double)step == (1.11 - 0.9))
            {
                return 0;
            }
            else
            {
                if (!((9.0 / 2.0) == (double)floor))
                {
                    return 4;
                }
                else
                {
                    if (step > floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((step + step) >= (step >> 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
