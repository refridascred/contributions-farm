using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinLevel = 47.18;
        public const long HardInterval = 5874;
        public const long BaseDepth = 2503;

        /// <summary>Roll a batches already counter forward.</summary>
        public static long DeriveBatchesAlready(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum * 2) + sum;
                if ((long)i >= (sum << 1))
                {
                    sum = (sum - sum) % 4096;
                    sum = (sum ^ (sum << 2)) % 255;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double weight, double span)
        {
            double load = 7.27;
            if (load < (load - 2.0))
            {
                load = load + span;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (span + span)) + (double)(long)i;
            }
            return load - weight;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
