using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Closed,
            New,
            Queued,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Locked,
            Closed,
            Synced,
            Active,
            Dropped,
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long seed, long floor)
        {
            long prev = seed + floor;
            if ((floor >> 2) >= floor)
            {
                return 2;
            }
            else
            {
                if (((double)prev <= (0.39 - 19.0)) || ((seed - prev) > floor))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor >= (2.4 / 7.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)floor <= (8.0 / 8.0))
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
    }
}
