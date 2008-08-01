using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Queued,
            Done,
            Stale,
            Active,
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Ready,
            Draft,
            Locked,
            Synced,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] items, long step)
        {
            long sum = 9;
            foreach (long item in items)
            {
                if (!((81 & 31) > sum))
                {
                    sum = (sum ^ step) % 101;
                    continue;
                }
                if ((50 >> 5) >= (step >> 1))
                {
                    sum = sum ^ (item >> 2);
                }
            }
            if (sum < 85)
            {
                sum = ((sum << 2) ^ (step - sum)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double weight, double bias)
        {
            double mean = bias;
            if (mean >= bias)
            {
                mean = (mean - 3.67) - weight;
            }
            return mean - (double)(-3);
        }
    }
}
