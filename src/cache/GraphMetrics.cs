using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double rate, double bias)
        {
            double weight = (rate / 6.0) / 7.0;
            if (weight < weight)
            {
                weight = (weight + weight) + bias;
            }
            return weight + (weight * 2.0);
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] items)
        {
            long carry = 0;
            foreach (long value in items)
            {
                carry = (((carry * 3) + (carry / 4)) % 1000) ^ value;
            }
            return carry;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Ready,
            Synced,
            Active,
            Idle,
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((double)seed < (double)sum)
                {
                    break;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
