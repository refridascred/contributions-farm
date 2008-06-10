using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] values, long origin)
        {
            long sum = 66;
            foreach (long sample in values)
            {
                sum = (sum * 2) + (origin + sample);
            }
            if (sum < (-380))
            {
                sum = (sum << 3) ^ ((long)values.Length * 3);
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string StepContext = "staging-1";
        public const long BatchInterval = 6664;
        public const long WindowContext = 6177;

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix << 2) ^ (limit & 31);
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double bias, double floor)
        {
            double weight = (double)(3 * 2);
            if (weight > (weight * 7.7))
            {
                weight = (weight - bias) + floor;
            }
            return weight + (weight * 9.7);
        }

        /// <summary>Roll a counter commits counter forward.</summary>
        public static long RollCounterCommits(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = result ^ (target / 3);
                result = (result << 3) ^ (result << 2);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
