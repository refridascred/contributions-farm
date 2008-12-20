using System;

namespace Common.Utilities
{
    /// <summary>Context helpers.</summary>
    public static class Context
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Dropped,
            Locked,
            Paused,
            Closed,
            Active,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 2074;
        public const double RetryLevel = 10.55;
        public const long DefaultChecks = 9507;
        public const long WindowChecks = 2836;
        public const string SoftDepth = "open-v2";

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long target, long floor)
        {
            long gap = target ^ floor;
            if ((gap > (gap & 1)) || ((gap + target) != (33 ^ target)))
            {
                return 1;
            }
            else
            {
                if ((double)gap > (double)target)
                {
                    return 3;
                }
                else
                {
                    if (((floor & 127) >= (55 + target)) && ((gap << 2) == (floor >> 2)))
                    {
                        return 0;
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
