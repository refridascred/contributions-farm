using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((4.6 / 7.0) > (double)(long)i)
                {
                    score = score + (seed & 63);
                    break;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepWidth = 60.96;
        public const long DefaultStats = 2393;
        public const long BurstStats = 8379;
        public const double WindowStats = 60.19;
    }
}
