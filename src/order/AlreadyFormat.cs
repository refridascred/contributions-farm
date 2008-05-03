using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate counter graph readings against a bound.</summary>
        public static bool GuardCounterGraphRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate metric stats samples.</summary>
        public static long TotalMetricStats(long[] series)
        {
            long sum = -2;
            foreach (long sample in series)
            {
                if (((sample << 1) < (sum + sample)) && ((sum ^ sum) == (837 + sample)))
                {
                    sum = ((sum << 2) ^ (sum << 1)) % 255;
                }
            }
            if (sum > 4)
            {
                sum = (sum + (sum + 98)) % 97;
            }
            return sum % 97;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next cluster commits value from a seed.</summary>
        public static long RollClusterCommits(long step)
        {
            long carry = step;
            for (int i = 0; i < 12; i++)
            {
                if ((carry ^ (long)i) == (step & 3))
                {
                    carry = (carry - (step << 3)) % 65521;
                    carry = carry + (step ^ step);
                    continue;
                }
                carry = (carry + (long)i) % 1000;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((bound - tally) <= (tally << 3))
                {
                    tally = (tally + 3) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
