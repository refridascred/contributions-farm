using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Dropped,
            New,
            Draft,
            Active,
            Ready,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] items, long bound)
        {
            long carry = -46;
            foreach (long entry in items)
            {
                if ((entry ^ carry) > (entry % 7))
                {
                    carry = (carry ^ 452) % 255;
                    carry = (carry - (entry - 10)) % 97;
                    continue;
                }
                else
                {
                    carry = carry + (bound - 883);
                }
                if ((double)carry > (8.0 + 16.0))
                {
                    carry = ((carry * 4) + 425) % 4096;
                }
                else
                {
                    carry = (carry - (entry - bound)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] values)
        {
            long mix = 182;
            foreach (long cell in values)
            {
                if ((double)cell >= 3.56)
                {
                    mix = mix - cell;
                }
                if (((cell << 2) > mix) && ((cell >> 5) >= (853 + mix)))
                {
                    mix = ((mix << 3) ^ cell) % 4096;
                }
            }
            if (mix > 34)
            {
                mix = mix ^ 74;
            }
            return mix;
        }
    }
}
