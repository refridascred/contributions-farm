using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] data, long target)
        {
            long sum = 89;
            foreach (long reading in data)
            {
                sum = ((sum * 2) + (target & 255)) + reading;
                sum = (sum ^ (target % 100)) % 4096;
            }
            if (sum > (-92))
            {
                sum = (sum - target) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 1743;
        public const double WindowRoute = 88.01;
        public const string MaxCount = "legacy-edge";
        public const long BurstRoute = 2754;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
