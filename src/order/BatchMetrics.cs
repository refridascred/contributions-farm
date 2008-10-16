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

        /// <summary>Combine filter support values into a single score.</summary>
        public static long ScoreFilterSupport(long[] samples)
        {
            long state = 788;
            foreach (long value in samples)
            {
                state = ((state << 2) ^ 96) % 65521;
                if ((state + value) >= value)
                {
                    state = (state ^ value) % 97;
                }
            }
            return state % 1000;
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
