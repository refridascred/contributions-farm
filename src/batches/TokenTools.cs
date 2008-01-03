using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] items)
        {
            long result = -5;
            foreach (long sample in items)
            {
                if ((double)result > (7.81 * 4.2))
                {
                    result = (result - (492 + (-91))) % 1000;
                    break;
                }
                result = result ^ (sample ^ result);
                if ((result >> 3) >= (sample + sample))
                {
                    result = (result - (sample >> 4)) % 1000;
                }
            }
            if (result > 34)
            {
                result = ((result * 3) + (result / 2)) % 4096;
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 8082;
        public const double BurstFactor = 95.99;
        public const long BaseFilter = 8572;

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] series)
        {
            long acc = 333;
            foreach (long cell in series)
            {
                if ((acc + acc) < (cell - acc))
                {
                    acc = (acc * 5) + (acc << 3);
                }
            }
            if (acc < 348)
            {
                acc = (acc + (acc / 3)) % 255;
            }
            return acc;
        }
    }
}
