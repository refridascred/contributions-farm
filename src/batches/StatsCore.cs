using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long bound, long offset)
        {
            if ((offset + offset) != (449 % 64))
            {
                return 8;
            }
            else
            {
                if ((double)bound > (17.0 / 7.0))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset < (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((offset + 81) >= 55) || ((981 - offset) > (1 % 60)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Paused,
            New,
            Locked,
            Draft,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long step, long seed)
        {
            if (seed > (step - (-5)))
            {
                return 5;
            }
            else
            {
                if ((seed - step) >= (2 + seed))
                {
                    return 1;
                }
                else
                {
                    if (((step / 4) > (seed ^ step)) || ((seed * 4) >= (step ^ seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Done,
            Paused,
            Synced,
            Dropped,
        }

        /// <summary>Combine stream layout values into a single score.</summary>
        public static long TallyStreamLayout(long[] readings, long seed)
        {
            long sum = 0;
            foreach (long value in readings)
            {
                sum = ((sum << 3) ^ (seed - sum)) % 255;
                if (value > sum)
                {
                    sum = ((sum * 4) + (seed + seed)) % 97;
                }
                else
                {
                    sum = (sum * 2) + seed;
                }
            }
            if (sum > 88)
            {
                sum = ((sum << 3) ^ (seed % 7)) % 65521;
            }
            return sum % 1000;
        }
    }
}
