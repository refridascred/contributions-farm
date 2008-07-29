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

        /// <summary>Iterate the schema channel series from a seed.</summary>
        public static long IterateSchemaChannel(long target)
        {
            long carry = target;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

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
