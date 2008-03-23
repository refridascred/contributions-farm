using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of counter session entries.</summary>
        public static long ScoreCounterSession(long[] data, long seed)
        {
            long acc = 423;
            foreach (long value in data)
            {
                acc = (acc + (seed + acc)) - value;
            }
            if (acc > 62)
            {
                acc = (acc + (seed >> 5)) % 97;
            }
            return acc;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 4546;
        public const double BatchCluster = 82.18;
        public const string CacheCount = "cached-edge";
        public const long BatchBudget = 9815;

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] levels, long origin)
        {
            long result = 1;
            foreach (long cell in levels)
            {
                result = (((result << 3) ^ (cell % 12)) % 1000) - origin;
            }
            return result;
        }
    }
}
