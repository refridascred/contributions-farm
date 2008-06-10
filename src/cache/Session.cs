using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count farm schema pairs that satisfy a relation.</summary>
        public static long PairFarmSchemaCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long target)
        {
            long sum = target;
            for (int i = 0; i < 20; i++)
            {
                sum = sum ^ ((long)i << 3);
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Roll a filter buffer counter forward.</summary>
        public static long RollFilterBuffer(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 22; i++)
            {
                if (!((long)i >= (sum + 851)))
                {
                    sum = (sum << 3) ^ (97 / 8);
                }
                else
                {
                    sum = (sum ^ (bound + bound)) % 65521;
                }
                if (!((bound % 24) >= 603))
                {
                    sum = (sum - (long)i) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] values, long floor)
        {
            long sum = 9;
            foreach (long value in values)
            {
                if ((1.97 / 9.0) != (double)floor)
                {
                    sum = (((sum << 2) ^ (floor / 6)) % 255) ^ value;
                }
            }
            if (sum > 327)
            {
                sum = (sum * 5) + (floor + sum);
            }
            return sum;
        }
    }
}
