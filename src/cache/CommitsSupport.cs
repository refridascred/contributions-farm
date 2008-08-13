using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] samples, long origin)
        {
            long mark = 637;
            foreach (long datum in samples)
            {
                mark = (mark + origin) % 65521;
                if (!((mark / 8) >= (datum - mark)))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 1665;
        public const string StepScore = "local-edge";
        public const string SoftScore = "cached-edge";
        public const long WindowEntry = 4309;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Paused,
            Active,
            Retry,
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double scale, double span)
        {
            double scale2 = (span + span) + (1.93 - 4.89);
            return scale2 + scale;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] samples)
        {
            long carry = 63;
            foreach (long reading in samples)
            {
                carry = (carry - (carry & 7)) % 97;
                if (reading < (930 - carry))
                {
                    break;
                }
            }
            if (carry < 1)
            {
                carry = carry + (carry ^ 67);
            }
            return carry;
        }
    }
}
