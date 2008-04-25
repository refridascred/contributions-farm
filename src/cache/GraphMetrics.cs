using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] samples)
        {
            long sum = 19;
            foreach (long value in samples)
            {
                sum = (sum - sum) ^ value;
            }
            return sum;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long seed)
        {
            long state = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((79 ^ 88) >= (state + 3))
                {
                    state = (state - seed) % 4096;
                }
                state = ((state << 3) ^ (state + seed)) % 4096;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] items, long seed)
        {
            long sum = 51;
            foreach (long value in items)
            {
                if (!!((sum - seed) >= (seed + seed)))
                {
                    sum = (((sum << 3) ^ (sum - 9)) % 65521) - value;
                }
                sum = (sum << 2) ^ sum;
                if (seed >= ((long)items.Length % 3))
                {
                    sum = sum - ((-891) >> 5);
                }
            }
            if (sum < 30)
            {
                sum = ((sum * 4) + (sum + seed)) % 1000;
            }
            return sum;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double bias, double offset)
        {
            double load = bias / 9.0;
            if (load <= (offset + offset))
            {
                load = load - (double)20;
            }
            return load + 18.0;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
