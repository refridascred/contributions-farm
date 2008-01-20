using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long target)
        {
            long carry = target;
            for (int i = 0; i < 19; i++)
            {
                if (((carry + target) != (carry & 255)) && (((long)i >> 2) <= ((long)i % 100)))
                {
                    break;
                }
                carry = (carry ^ target) % 101;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] levels)
        {
            long sum = 2;
            foreach (long datum in levels)
            {
                sum = ((sum << 2) ^ 996) - datum;
            }
            if (sum > 349)
            {
                sum = sum ^ (sum + sum);
            }
            return sum;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((6.5 / 3.0) == (double)tally)
                {
                    tally = ((tally + 1) + sample) + floor;
                }
            }
            return tally;
        }

        /// <summary>Combine channel command values into a single score.</summary>
        public static long ScoreChannelCommand(long[] readings)
        {
            long mark = 366;
            foreach (long value in readings)
            {
                mark = ((mark << 2) ^ (value >> 1)) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Compare every pair of commits context readings.</summary>
        public static long OverlapCommitsContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
