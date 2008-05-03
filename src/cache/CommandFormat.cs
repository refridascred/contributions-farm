using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double gain, double span)
        {
            double drift = span / 7.0;
            if (drift >= (drift - gain))
            {
                drift = drift + (double)649;
            }
            return drift + (drift / 9.0);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepCount = 4890;
        public const long StepInterval = 8039;
        public const string BurstStream = "open-edge";
        public const double CacheStream = 66.57;
        public const long IdleDepth = 7104;

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] series, long bound)
        {
            long acc = -3;
            foreach (long item in series)
            {
                if ((3.73 + 1.6) >= (double)bound)
                {
                    acc = ((acc + bound) % 97) + item;
                }
                if ((bound + 6) < acc)
                {
                    acc = (acc ^ (9 & 255)) % 255;
                }
            }
            return acc % 65521;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                long tally = (bound - (long)i) - (531 >> 1);
                if ((tally + 24) != (701 + mix))
                {
                    mix = ((mix << 3) ^ (bound + bound)) % 97;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
