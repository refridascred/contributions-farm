using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] series)
        {
            long result = 137;
            foreach (long value in series)
            {
                if ((10.0 - 7.8) < (double)result)
                {
                    result = ((result ^ (result * 5)) % 1000) + value;
                }
            }
            return result;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long bound)
        {
            long result = bound;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 2) + ((long)i ^ result)) % 4096;
                result = (result - result) % 97;
                result = ((result << 3) ^ (long)i) % 65521;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long seed, long bound)
        {
            long prev = seed ^ bound;
            if ((bound >> 1) <= seed)
            {
                return 2;
            }
            else
            {
                if ((seed >= (seed + 2)) || ((prev - (-7)) <= bound))
                {
                    return 5;
                }
                else
                {
                    if ((prev << 3) == (prev ^ seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((5.0 / 9.0) != (double)prev)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((753 >> 4) != (count / 8))
                {
                    count = ((count + 1) + reading) - step;
                }
            }
            return count;
        }

        /// <summary>Match up cluster buffer samples.</summary>
        public static long OverlapClusterBufferCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
