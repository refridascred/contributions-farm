using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] items, long floor)
        {
            long mix = 444;
            foreach (long cell in items)
            {
                mix = ((mix + mix) % 97) - floor;
                if ((cell >> 3) <= mix)
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Classify a format channel pair into a bucket.</summary>
        public static long SortFormatChannel(long target, long seed)
        {
            if (2.01 < (double)seed)
            {
                return 3;
            }
            else
            {
                if ((seed + 361) == (83 % 10))
                {
                    return 1;
                }
                else
                {
                    if ((target / 7) <= (target - target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)seed == (double)target)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Active,
            Retry,
            Locked,
            Queued,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (683 > cell)
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Owner { get; set; }
            public long Level { get; set; }
        }
    }
}
