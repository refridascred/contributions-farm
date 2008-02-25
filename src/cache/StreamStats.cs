using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long floor, long offset)
        {
            if (offset < (offset << 3))
            {
                return 5;
            }
            else
            {
                if ((double)floor > (6.61 + 2.31))
                {
                    return 1;
                }
                else
                {
                    if ((offset + offset) <= floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor <= offset) && ((floor * 2) != (offset / 4)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first contributi stats entry that matches the target.</summary>
        public static long LookupContributiStatsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Dropped,
            Locked,
            Active,
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
