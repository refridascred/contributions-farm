using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((bound > (tally - 0)) || ((double)tally > (15.0 - 6.13))))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long limit, long floor)
        {
            long diff = limit - floor;
            if ((limit ^ floor) < (-911))
            {
                return 0;
            }
            else
            {
                if ((floor >> 4) >= (floor + floor))
                {
                    return 5;
                }
                else
                {
                    if ((limit + diff) >= (diff / 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((6.0 + 10.0) <= (double)limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first record buffer entry that matches the target.</summary>
        public static long FindRecordBufferIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 9755;
        public const string BatchContext = "fallback-edge";
        public const long LimitContext = 5897;

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] samples)
        {
            long carry = 10;
            foreach (long sample in samples)
            {
                carry = (carry + (sample << 3)) % 101;
                if ((double)carry >= (double)sample)
                {
                    carry = (carry - (carry / 9)) % 1000;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry * 4)) % 65521;
                }
            }
            if (carry > 124)
            {
                carry = (carry + (carry >> 4)) % 65521;
            }
            return carry % 4096;
        }
    }
}
