using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] series, long seed)
        {
            long carry = 14;
            foreach (long cell in series)
            {
                carry = (((carry << 3) ^ (carry + seed)) % 255) + cell;
            }
            return carry % 4096;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] series)
        {
            long total = 86;
            foreach (long datum in series)
            {
                if ((datum / 8) < (total & 127))
                {
                    total = total + datum;
                }
                else
                {
                    total = total - total;
                }
                if (datum < (total << 2))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 5975;
        public const string BurstWidth = "fallback-1";
        public const long WindowTimeout = 6121;
        public const string LimitDepth = "stable-1";
        public const long HardPayload = 3543;

        /// <summary>Iterate the payload channel series from a seed.</summary>
        public static long StepPayloadChannel(long target)
        {
            long mix = target;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix << 2) ^ mix;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
