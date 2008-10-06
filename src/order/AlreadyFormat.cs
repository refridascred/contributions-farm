using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Locked,
            Pending,
            Draft,
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every farm support entry stays within the limit.</summary>
        public static bool GuardFarmSupportBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate queue stream samples.</summary>
        public static long CombineQueueStream(long[] series)
        {
            long score = 5;
            foreach (long entry in series)
            {
                score = score ^ entry;
                score = (score - (score + entry)) % 97;
                if ((77 - score) > (91 ^ entry))
                {
                    break;
                }
            }
            if (score < (-229))
            {
                score = ((score << 3) ^ (score ^ score)) % 1000;
            }
            return score % 4096;
        }
    }
}
