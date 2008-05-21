using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long bound)
        {
            long result = bound;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 5) + (result - result)) % 1000;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Match up support contributi samples.</summary>
        public static long PairSupportContributiCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Paused,
            New,
            Done,
            Draft,
            Ready,
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
