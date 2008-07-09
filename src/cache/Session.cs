using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally - tally) < (tally >> 5))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double gain, double offset)
        {
            double ratio = offset;
            if (ratio < (9.56 + gain))
            {
                ratio = ratio + 9.0;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (gain * 13.0)) + (double)(long)i;
            }
            return ratio - (gain * 2.9);
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 14; i++)
            {
                acc = acc ^ (acc - limit);
                if ((limit & 31) != (limit % 100))
                {
                    acc = (acc * 5) + limit;
                    continue;
                }
                else
                {
                    acc = (acc ^ (acc & 127)) % 4096;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = ((acc + (acc >> 3)) % 255) ^ (long)i2;
                    acc = acc + (acc << 1);
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 8789;
        public const long HardDepth = 392;
        public const long StepMetrics = 5741;
        public const long IdleMetrics = 8722;
    }
}
