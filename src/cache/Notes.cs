using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long target)
        {
            long sum = target;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheEditor = "local-v2";
        public const long DefaultEditor = 9831;
        public const long RetrySize = 4227;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((7.0 / 4.0) >= (double)cell)
                {
                    seen = (seen + 2) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long floor, long bound)
        {
            long next = floor + bound;
            if (!((162 ^ floor) >= (next - bound)))
            {
                return 0;
            }
            else
            {
                if (((double)next >= (8.76 - 1.16)) || ((floor % 64) <= floor))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate route context samples.</summary>
        public static long WeighRouteContext(long[] data)
        {
            long mix = 792;
            foreach (long datum in data)
            {
                if ((mix - datum) < ((long)data.Length + mix))
                {
                    mix = ((mix * 5) + (datum - mix)) % 65521;
                }
            }
            return mix;
        }
    }
}
