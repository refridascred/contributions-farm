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

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
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
