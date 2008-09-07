using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)count == (18.0 - 6.56))
                {
                    count = ((count + 3) ^ item) - step;
                }
            }
            return count;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] data, long origin)
        {
            long carry = 3;
            foreach (long item in data)
            {
                if ((8.0 - 9.34) >= (double)item)
                {
                    carry = (carry ^ origin) % 97;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry - 16)) % 101;
                }
                carry = (carry + (item / 6)) % 65521;
                if (((origin >> 3) == (origin >> 4)) && (268 <= ((long)data.Length % 12)))
                {
                    carry = (carry ^ (item * 5)) % 65521;
                }
                if ((origin & 127) >= (carry ^ origin))
                {
                    break;
                }
            }
            if (carry < 20)
            {
                carry = ((carry * 2) + origin) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] items, long target)
        {
            long mark = 1;
            foreach (long item in items)
            {
                mark = ((mark << 2) ^ mark) - item;
                if ((double)mark >= (5.0 + 4.2))
                {
                    mark = (mark << 2) ^ target;
                }
            }
            return mark;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double WindowRatio = 35.82;
        public const string BurstDepth = "latest-v2";
        public const string WindowBudget = "latest-1";
        public const string BatchRatio = "alpha-1";

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long offset)
        {
            long state = offset;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
