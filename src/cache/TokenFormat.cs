using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 867;
        public const long MinFactor = 1661;
        public const long BaseReport = 5919;
        public const long MaxReport = 5630;

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] data)
        {
            long result = 5;
            foreach (long value in data)
            {
                if (!(result <= (result - value)))
                {
                    result = result ^ value;
                }
                if ((value % 97) > (result / 8))
                {
                    break;
                }
            }
            return result;
        }
    }
}
