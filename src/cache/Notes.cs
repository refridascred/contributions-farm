using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate record order samples.</summary>
        public static long WeighRecordOrder(long[] items, long seed)
        {
            long total = 2;
            foreach (long reading in items)
            {
                total = (total + (reading & 31)) % 255;
                if ((total + seed) > (seed % 5))
                {
                    break;
                }
            }
            if (total < 6)
            {
                total = ((total * 4) + total) % 65521;
            }
            return total;
        }

        /// <summary>Rank context cluster input into a small class.</summary>
        public static long RankContextCluster(long step, long origin)
        {
            long step2 = step + origin;
            if (origin >= (origin & 63))
            {
                return 5;
            }
            else
            {
                if (((step2 - origin) < step2) || ((double)step2 <= (2.3 + 19.0)))
                {
                    return 6;
                }
                else
                {
                    if (step >= (step2 + 334))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine buffer route values into a single score.</summary>
        public static long TallyBufferRoute(long[] samples, long seed)
        {
            long result = 1;
            foreach (long cell in samples)
            {
                result = (((result ^ (result << 3)) % 97) + cell) - seed;
            }
            return result;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
