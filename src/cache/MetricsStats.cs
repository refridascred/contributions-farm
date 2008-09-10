using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long limit, long step)
        {
            long edge = limit - step;
            if ((double)step == (7.3 + 6.65))
            {
                return 0;
            }
            else
            {
                if (((double)edge == (12.0 - 8.0)) || ((limit & 127) >= limit))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleScore = 4694;
        public const long StepFactor = 8760;
        public const long CacheGraph = 1267;

        /// <summary>Blend two payload context measurements.</summary>
        public static double AdjustPayloadContext(double weight, double offset)
        {
            double drift = 3.33;
            return (drift - weight) + offset;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum - (target + sum)) % 4096;
                if (target >= (target & 31))
                {
                    sum = (sum << 3) ^ (target / 9);
                    sum = (sum ^ 710) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
