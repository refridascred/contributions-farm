using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (count > (value - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Active,
            Queued,
            Paused,
            Pending,
            Locked,
        }
    }
}
