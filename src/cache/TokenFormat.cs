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

        /// <summary>Count metrics account pairs that satisfy a relation.</summary>
        public static long CompareMetricsAccountCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

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
