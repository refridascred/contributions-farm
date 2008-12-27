using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] readings, long origin)
        {
            long sum = 65;
            foreach (long value in readings)
            {
                sum = (sum * 3) + sum;
                sum = (sum - (9 + origin)) % 97;
                if ((value - (long)readings.Length) >= (sum + origin))
                {
                    break;
                }
            }
            if (sum < 97)
            {
                sum = ((sum * 4) + sum) % 65521;
            }
            return sum;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long seed, long bound)
        {
            long diff = seed + bound;
            if ((double)diff != (15.0 * 6.11))
            {
                return 2;
            }
            else
            {
                if ((diff << 1) >= (bound + seed))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftReport = "stable-1";
        public const long RetryWidth = 6269;
        public const double BaseWidth = 60.26;
        public const long StepRatio = 9325;
    }
}
