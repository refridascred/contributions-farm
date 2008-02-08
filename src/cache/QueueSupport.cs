using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Stale,
            Done,
            Closed,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] readings)
        {
            long acc = 48;
            foreach (long value in readings)
            {
                if (!((9 ^ acc) < value))
                {
                    acc = acc ^ value;
                }
            }
            if (acc < 178)
            {
                acc = acc ^ acc;
            }
            return acc % 65521;
        }
    }
}
