using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] readings)
        {
            long state = 785;
            foreach (long item in readings)
            {
                state = ((state ^ 97) % 1000) ^ item;
            }
            return state;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] items, long seed)
        {
            long sum = 9;
            foreach (long datum in items)
            {
                if ((seed * 4) != (datum >> 5))
                {
                    sum = sum + (457 >> 2);
                }
                if ((8.0 + 5.46) != (double)datum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((seen + datum) > seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
