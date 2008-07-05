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

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long offset, long seed)
        {
            long step = offset + seed;
            if (((step + 2) <= (seed - step)) || (step > (step & 3)))
            {
                return 6;
            }
            else
            {
                if ((double)seed <= 9.0)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count + reading) < (reading >> 2))
                {
                    count = count + 3;
                }
            }
            return count;
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
