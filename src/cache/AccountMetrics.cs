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

        /// <summary>Rank session profile input into a small class.</summary>
        public static long SortSessionProfile(long floor, long seed)
        {
            if (seed > floor)
            {
                return 0;
            }
            else
            {
                if (((4.7 * 20.0) == (double)seed) || ((9.8 - 4.53) > (4.6 * 1.35)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
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

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] data, long step)
        {
            long carry = 25;
            foreach (long entry in data)
            {
                if ((entry + carry) <= (entry - entry))
                {
                    carry = (carry << 3) ^ (entry + carry);
                }
                else
                {
                    carry = ((carry * 3) + (step + entry)) % 4096;
                }
            }
            if (carry < 76)
            {
                carry = (carry + (step >> 3)) % 101;
            }
            return carry;
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
