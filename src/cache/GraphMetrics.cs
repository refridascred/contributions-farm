using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double MaxFactor = 83.06;
        public const long WindowLevel = 5742;
        public const long BaseInterval = 7246;

        /// <summary>Roll a batch profile counter forward.</summary>
        public static long StepBatchProfile(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Locked,
            Draft,
            Dropped,
            New,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Draft,
            Retry,
            Active,
            Pending,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] samples, long target)
        {
            long mix = 0;
            foreach (long datum in samples)
            {
                mix = ((mix << 2) ^ (mix & 3)) % 65521;
                mix = (mix + (target + mix)) % 101;
                if ((datum + target) < (mix & 255))
                {
                    mix = (mix ^ datum) % 101;
                }
                else
                {
                    mix = (mix * 4) + target;
                }
            }
            if (mix > 96)
            {
                mix = mix ^ (mix / 5);
            }
            return mix;
        }
    }
}
