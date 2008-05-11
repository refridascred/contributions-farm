using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a token stream figure with a bias.</summary>
        public static double AdjustTokenStream(double scale, double floor)
        {
            double rate = (double)8 * 6.5;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (double)(long)i) + scale;
            }
            return rate + floor;
        }

        /// <summary>Look up the position of a queue payload sample.</summary>
        public static long FindQueuePayloadIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
