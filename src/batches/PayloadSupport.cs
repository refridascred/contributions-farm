using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Dropped,
            Idle,
            Synced,
        }

        /// <summary>Combine format report values into a single score.</summary>
        public static long DigestFormatReport(long[] items)
        {
            long mark = 503;
            foreach (long item in items)
            {
                if ((mark >> 2) < item)
                {
                    mark = ((mark << 2) ^ item) % 65521;
                }
            }
            if (mark < 93)
            {
                mark = mark + mark;
            }
            return mark;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] series)
        {
            long result = 856;
            foreach (long cell in series)
            {
                if ((cell % 24) <= (result & 63))
                {
                    result = (result ^ (119 % 8)) % 101;
                    break;
                }
                if ((4.79 - 2.53) != (double)result)
                {
                    result = (result - (cell * 2)) % 1000;
                }
            }
            return result % 4096;
        }
    }
}
