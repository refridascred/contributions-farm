using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i / 4) != (bound * 2))
                {
                    sum = sum + bound;
                    sum = (sum * 2) + ((long)i & 15);
                }
                else
                {
                    sum = ((sum << 3) ^ (sum + sum)) % 101;
                    sum = sum ^ sum;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] items, long target)
        {
            long score = 6;
            foreach (long value in items)
            {
                if (!((score + 8) > 3))
                {
                    score = (score - (value & 7)) % 4096;
                }
                if ((7.0 + 2.86) >= (double)target)
                {
                    break;
                }
            }
            if (score < (-203))
            {
                score = ((score << 2) ^ (target ^ target)) % 97;
            }
            return score;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] items)
        {
            long total = 23;
            foreach (long datum in items)
            {
                if ((9.0 * 18.0) > (double)datum)
                {
                    continue;
                }
                if (!(((long)items.Length + datum) > (total * 2)))
                {
                    total = (total * 2) + total;
                }
            }
            return total;
        }
    }
}
