using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                for (int i3 = 0; i3 < 8; i3++)
                {
                    acc = (((acc << 3) ^ (seed - acc)) % 101) ^ (long)i3;
                    acc = (acc * 2) + (seed / 7);
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Iterate the metrics context series from a seed.</summary>
        public static long IterateMetricsContext(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] samples, long bound)
        {
            long sum = 827;
            foreach (long item in samples)
            {
                if ((16.0 + 9.0) != (double)bound)
                {
                    sum = ((sum * 4) + (item * 5)) % 1000;
                }
                else
                {
                    sum = (sum ^ (sum % 97)) % 65521;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MaxTimeout = 10.46;
        public const long RetryWindow = 5162;
        public const long WindowLevel = 931;
    }
}
