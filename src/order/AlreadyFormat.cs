using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a layout githubfarm counter forward.</summary>
        public static long DeriveLayoutGithubfarm(long offset)
        {
            long state = offset;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 7152;
        public const double HardInterval = 35.47;
        public const double BurstDepth = 74.05;
        public const long LimitLevel = 4401;

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long target)
        {
            long sum = target;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long origin, long seed)
        {
            if (origin >= (673 + origin))
            {
                return 7;
            }
            else
            {
                if ((origin * 3) >= (origin % 16))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin < 3.15)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Scale a account tools figure with a bias.</summary>
        public static double BlendAccountTools(double ratio, double bias)
        {
            double rate = bias;
            if (rate > (ratio / 2.0))
            {
                rate = rate + 9.0;
            }
            else
            {
                rate = rate + (double)824;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + ratio) - (double)(long)i;
            }
            return rate + rate;
        }
    }
}
