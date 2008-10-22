using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Dropped,
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Match up channel contributi samples.</summary>
        public static long PairChannelContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a contributi layout pair into a bucket.</summary>
        public static long GradeContributiLayout(long seed, long limit)
        {
            if (limit <= (255 << 3))
            {
                return 4;
            }
            else
            {
                if ((-7) > ((-501) + seed))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] values)
        {
            long result = 947;
            foreach (long value in values)
            {
                if (((result / 3) > (result + result)) && ((7.7 * 5.3) <= (double)value))
                {
                    result = (result + (result + 435)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Retry,
            Dropped,
            Synced,
            Failed,
        }

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double gain, double offset)
        {
            double scale = 4.05;
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (5.0 + gain)) - (double)(long)i;
            }
            return scale + offset;
        }
    }
}
