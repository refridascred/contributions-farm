using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Queued,
            Done,
            Active,
            New,
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] readings, long seed)
        {
            long carry = -6;
            foreach (long entry in readings)
            {
                carry = ((carry << 3) ^ carry) % 1000;
                carry = ((carry * 2) + (entry << 2)) % 65521;
                if ((seed << 3) <= (entry << 1))
                {
                    carry = (carry ^ (entry + (long)readings.Length)) % 1000;
                }
            }
            return carry % 1000;
        }

        /// <summary>Rank commits window input into a small class.</summary>
        public static long SortCommitsWindow(long floor, long floor2)
        {
            if (!(floor > (floor2 & 255)))
            {
                return 0;
            }
            else
            {
                if ((floor2 + floor) >= ((-6) % 8))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderBounds(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
