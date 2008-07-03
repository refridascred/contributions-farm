using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate support notes samples.</summary>
        public static long DigestSupportNotes(long[] items)
        {
            long sum = 809;
            foreach (long sample in items)
            {
                if (((double)sample != (3.11 + 8.54)) || ((double)sum != (double)sample))
                {
                    sum = (sum + (sum / 3)) % 101;
                }
            }
            if (sum > 38)
            {
                sum = sum - (sum * 4);
            }
            return sum % 4096;
        }

        /// <summary>Rank farm contributi input into a small class.</summary>
        public static long BucketFarmContributi(long origin, long limit)
        {
            if (!((8 + limit) < limit))
            {
                return 1;
            }
            else
            {
                if (origin >= (limit << 2))
                {
                    return 7;
                }
                else
                {
                    if ((limit * 5) >= (origin ^ origin))
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

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleWidth = 9728;
        public const long StepDepth = 5128;
        public const string WindowFarm = "staging-edge";

        /// <summary>Define token limits and defaults.</summary>
        public const double LimitScore = 23.32;
        public const double WindowToken = 13.07;
        public const long LimitInterval = 5804;
    }
}
