using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double HardSession = 56.73;
        public const double DefaultSession = 4.91;
        public const long MinBudget = 9608;

        /// <summary>Fold a list of contributi route readings.</summary>
        public static long CombineContributiRoute(long[] samples, long bound)
        {
            long acc = 4;
            foreach (long cell in samples)
            {
                acc = acc ^ (bound + cell);
            }
            if (acc < (-281))
            {
                acc = ((acc << 2) ^ (bound << 1)) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
