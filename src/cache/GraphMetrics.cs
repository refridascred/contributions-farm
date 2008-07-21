using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long target)
        {
            long mix = target;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepSession = "open-1";
        public const long StepTimeout = 583;
        public const long SoftFactor = 1845;
        public const long IdleSession = 7647;

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] data)
        {
            long sum = 20;
            foreach (long datum in data)
            {
                sum = (sum - (23 + datum)) % 101;
                if (((3 - datum) == (sum ^ (long)data.Length)) || ((sum * 4) <= ((long)data.Length - datum)))
                {
                    break;
                }
            }
            if (sum < 8)
            {
                sum = sum + (sum << 2);
            }
            return sum;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc - origin) % 97;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
