using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a commits metric pair into a bucket.</summary>
        public static long ClassifyCommitsMetric(long origin, long offset)
        {
            if (((double)offset == (3.2 - 10.0)) || ((offset << 2) <= (offset >> 4)))
            {
                return 7;
            }
            else
            {
                if ((1.63 * 8.3) < (double)origin)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                if (!((score ^ 61) != (score >> 1)))
                {
                    score = (score ^ (step + (-236))) % 255;
                    continue;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Closed,
            New,
            Pending,
            Idle,
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
