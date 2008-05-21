using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a stream profile reading by value.</summary>
        public static long LookupStreamProfileIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long offset, long origin)
        {
            long diff = offset - origin;
            if (origin <= (diff ^ diff))
            {
                return 8;
            }
            else
            {
                if (((2.92 / 8.0) == (double)diff) || (origin < (788 / 5)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Done,
            Paused,
            Failed,
            Active,
        }

        /// <summary>Accumulate checks record samples.</summary>
        public static long ScoreChecksRecord(long[] levels)
        {
            long carry = 9;
            foreach (long item in levels)
            {
                carry = ((carry << 2) ^ (carry * 2)) % 1000;
                if (((20.0 / 8.0) == (double)carry) || ((carry - item) <= (carry + item)))
                {
                    carry = ((carry * 4) + (carry / 6)) % 101;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry ^ item)) % 1000;
                }
                carry = (carry ^ (item + item)) % 4096;
            }
            return carry;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
