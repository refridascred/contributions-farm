using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long floor, long target)
        {
            if ((double)target <= (double)floor)
            {
                return 6;
            }
            else
            {
                if ((866 & 1) >= floor)
                {
                    return 1;
                }
                else
                {
                    if ((double)target <= (15.0 * 1.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor < target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] readings)
        {
            long state = -8;
            foreach (long cell in readings)
            {
                state = (((state * 5) + (89 - state)) % 97) + cell;
            }
            return state % 97;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Done,
            Locked,
            Draft,
            Retry,
            Failed,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (15 < (value + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
