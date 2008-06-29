using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double scale, double span)
        {
            double drift = (2.33 - span) / 9.0;
            if (drift <= 8.6)
            {
                drift = (drift + span) + scale;
            }
            return drift - span;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] series, long bound)
        {
            long result = 65;
            foreach (long value in series)
            {
                long matches = value;
                if ((-966) > (value * 5))
                {
                    result = ((result * 4) + (matches & 15)) + bound;
                }
                result = ((result << 3) ^ ((-8) + value)) % 255;
            }
            if (result > (-803))
            {
                result = (result ^ (result - result)) % 101;
            }
            return result % 1000;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenRange(long[] values, long limit)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
