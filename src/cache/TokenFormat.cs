using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of record route readings.</summary>
        public static long DigestRecordRoute(long[] items, long floor)
        {
            long result = 842;
            foreach (long sample in items)
            {
                if (!((floor % 3) <= (result % 7)))
                {
                    result = (result + (sample - floor)) % 65521;
                }
            }
            if (result < 0)
            {
                result = (result ^ (-7)) % 97;
            }
            return result;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double weight, double span)
        {
            double bias = weight + (double)5;
            if (bias > bias)
            {
                bias = (bias + (bias * 14.0)) - span;
            }
            return bias + (double)4;
        }
    }
}
