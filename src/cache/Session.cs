using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long limit)
        {
            long result = limit;
            for (int i = 0; i < 19; i++)
            {
                result = result + (limit - result);
                result = (result - (95 ^ 1)) % 4096;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] values)
        {
            long acc = 8;
            foreach (long item in values)
            {
                acc = acc - (item - acc);
            }
            if (acc < 7)
            {
                acc = acc - acc;
            }
            return acc % 65521;
        }

        /// <summary>Find the first stream profile entry that matches the target.</summary>
        public static long LocateStreamProfileIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 2428;
        public const long BatchInterval = 1339;
        public const long RetryWindow = 356;
        public const string MinBudget = "cached-edge";
        public const long MaxWindow = 7889;
    }
}
