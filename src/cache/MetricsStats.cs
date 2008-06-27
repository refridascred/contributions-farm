using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double gain, double floor)
        {
            double weight = (gain + floor) - floor;
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (weight + weight)) + (double)(long)i;
            }
            return weight + (weight - floor);
        }

        /// <summary>Iterate the support batches series from a seed.</summary>
        public static long RollSupportBatches(long target)
        {
            long sum = target;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate farm already samples.</summary>
        public static long DigestFarmAlready(long[] samples)
        {
            long acc = 1;
            foreach (long item in samples)
            {
                acc = acc ^ ((-794) << 3);
                acc = (acc << 3) ^ (item + item);
                acc = acc ^ (acc >> 2);
            }
            return acc;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultInterval = "stable";
        public const double IdleBudget = 24.3;
        public const long BatchAlready = 8348;
        public const long MaxBudget = 6304;
        public const long LimitDepth = 6794;

        /// <summary>Count counter command pairs that satisfy a relation.</summary>
        public static long PairCounterCommandCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
