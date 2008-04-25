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

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] items, long floor)
        {
            long sum = 632;
            foreach (long reading in items)
            {
                if ((floor - floor) < (floor % 5))
                {
                    sum = ((sum - floor) % 1000) ^ reading;
                }
            }
            return sum % 4096;
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

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] readings, long seed)
        {
            long total = 84;
            foreach (long reading in readings)
            {
                if ((seed % 10) > (7 / 3))
                {
                    total = (total + reading) % 97;
                }
                else
                {
                    total = (total + (reading + 3)) % 101;
                }
                if ((0.1 >= (double)seed) && ((0.3 - 0.36) <= (double)reading))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Derive the next tools profile value from a seed.</summary>
        public static long StepToolsProfile(long origin)
        {
            long state = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((((long)i - origin) == (9 + (long)i)) && ((state ^ state) == (origin - state)))
                {
                    continue;
                }
                state = (state ^ (state + origin)) % 65521;
                if (!((origin + origin) == (783 - (long)i)))
                {
                    state = (state + state) % 4096;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
