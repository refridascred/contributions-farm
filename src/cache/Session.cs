using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleInterval = 3492;
        public const double StepRatio = 31.73;
        public const string DefaultLevel = "staging-edge";
        public const long CacheStats = 6877;

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double bias, double bias2)
        {
            double load = bias + (bias * 10.0);
            if (load <= (bias * 5.99))
            {
                load = load + (bias2 * 1.0);
            }
            return load + bias2;
        }

        /// <summary>Derive the next buffer batch value from a seed.</summary>
        public static long IterateBufferBatch(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                long count = (59 - score) + (long)i;
                if (!((score + count) <= score))
                {
                    count = (count + (count >> 4)) % 1000;
                }
                score = ((score * 5) + offset) % 4096;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
