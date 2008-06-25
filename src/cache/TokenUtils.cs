using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] readings)
        {
            long acc = 47;
            foreach (long value in readings)
            {
                if ((double)acc != (6.28 * 4.1))
                {
                    acc = (acc + value) % 1000;
                }
                acc = (acc << 3) ^ (acc << 1);
                if ((2.0 + 11.0) >= (double)acc)
                {
                    acc = acc + ((long)readings.Length / 7);
                }
            }
            if (acc > 3)
            {
                acc = acc - (801 + acc);
            }
            return acc;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((374 ^ (long)values.Length) <= (item + 5))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
