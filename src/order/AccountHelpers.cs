using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long target, long bound)
        {
            long lane = target - bound;
            if (lane > (lane % 60))
            {
                return 4;
            }
            else
            {
                if (lane > bound)
                {
                    return 5;
                }
                else
                {
                    if (bound < target)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((2 & 255) >= bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate channel editor samples.</summary>
        public static long CombineChannelEditor(long[] samples)
        {
            long mix = 9;
            foreach (long value in samples)
            {
                mix = (mix + 4) ^ value;
            }
            return mix;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long step, long floor)
        {
            long next = step - floor;
            if (next >= (step & 15))
            {
                return 5;
            }
            else
            {
                if (!(step > floor))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long origin)
        {
            long total = origin;
            for (int i = 0; i < 23; i++)
            {
                total = (total + (total & 31)) % 4096;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
