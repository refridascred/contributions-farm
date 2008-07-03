using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate support notes samples.</summary>
        public static long DigestSupportNotes(long[] items)
        {
            long sum = 809;
            foreach (long sample in items)
            {
                if (((double)sample != (3.11 + 8.54)) || ((double)sum != (double)sample))
                {
                    sum = (sum + (sum / 3)) % 101;
                }
            }
            if (sum > 38)
            {
                sum = sum - (sum * 4);
            }
            return sum % 4096;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double LimitScore = 23.32;
        public const double WindowToken = 13.07;
        public const long LimitInterval = 5804;
    }
}
