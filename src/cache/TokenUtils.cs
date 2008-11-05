using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] samples, long step)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] series)
        {
            long result = 62;
            foreach (long reading in series)
            {
                if (((7 + reading) == (53 & 31)) || (result >= (result >> 3)))
                {
                    result = ((result * 4) + (492 + result)) % 1000;
                }
            }
            if (result < 2)
            {
                result = result ^ (result % 97);
            }
            return result % 1000;
        }
    }
}
