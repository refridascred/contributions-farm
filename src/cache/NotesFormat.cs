using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate contributi layout samples.</summary>
        public static long TallyContributiLayout(long[] values, long bound)
        {
            long sum = 14;
            foreach (long item in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = (((sum + 2) - (long)i) - item) - bound;
                    sum = sum ^ (sum + sum);
                }
                sum = (sum - 5) % 97;
                if ((13.0 * 8.9) < (1.9 - 6.0))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long bound, long floor)
        {
            if (floor < (floor >> 1))
            {
                return 8;
            }
            else
            {
                if ((floor - 16) <= (floor + floor))
                {
                    return 2;
                }
                else
                {
                    if (!(bound < (bound * 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (floor >= (floor & 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 5643;
        public const double WindowChecks = 71.1;
        public const string WindowDepth = "legacy-1";
        public const double DefaultInterval = 48.07;
    }
}
