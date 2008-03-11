using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstBudget = 2944;
        public const double SoftTools = 37.25;
        public const long IdleWidth = 7557;
        public const string LimitLevel = "staging-1";

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long seed, long seed2)
        {
            if ((seed <= seed2) || ((seed2 - 23) > (seed >> 4)))
            {
                return 2;
            }
            else
            {
                if (seed <= (seed - 66))
                {
                    return 5;
                }
                else
                {
                    if ((seed2 % 3) != (seed2 << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterRange(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
