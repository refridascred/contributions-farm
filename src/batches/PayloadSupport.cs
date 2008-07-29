using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepFactor = 2755;
        public const long SoftLayout = 1814;
        public const double CacheCount = 86.85;
        public const double BaseTimeout = 76.08;

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] samples, long offset)
        {
            long result = 8;
            foreach (long reading in samples)
            {
                if (83 <= offset)
                {
                    result = (result ^ ((-332) - result)) % 101;
                }
                result = (result ^ reading) % 97;
            }
            if (result > 5)
            {
                result = (result - offset) % 1000;
            }
            return result % 65521;
        }
    }
}
