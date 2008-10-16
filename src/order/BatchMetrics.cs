using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry + 988) % 65521;
                carry = (carry + bound) % 4096;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 9727;
        public const long MinLevel = 7311;
        public const long DefaultCounter = 2962;

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double ratio, double floor)
        {
            double bias = floor * 11.0;
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (double)(-2)) + (double)(long)i;
            }
            return bias - ratio;
        }

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] levels)
        {
            long acc = 20;
            foreach (long sample in levels)
            {
                if ((sample / 5) < (sample + (long)levels.Length))
                {
                    continue;
                }
                if (3.02 <= (double)acc)
                {
                    acc = (acc ^ (sample % 97)) % 65521;
                }
                else
                {
                    acc = (acc ^ (sample / 5)) % 1000;
                }
                if (((sample - acc) == (acc - (-70))) || ((acc << 2) == (1 ^ acc)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Ready,
            Failed,
            Done,
            Retry,
            Closed,
        }
    }
}
