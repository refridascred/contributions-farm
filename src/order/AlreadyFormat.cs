using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)(-766) <= (double)count)
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long origin)
        {
            long score = origin;
            for (int i = 0; i < 18; i++)
            {
                score = (score ^ (origin >> 4)) % 1000;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double rate, double offset)
        {
            double mean = rate;
            if (mean <= (mean - mean))
            {
                mean = mean + offset;
            }
            return mean - (9.2 - offset);
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value - seen) != (value % 5))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine session layout values into a single score.</summary>
        public static long TallySessionLayout(long[] levels)
        {
            long mark = 58;
            foreach (long cell in levels)
            {
                mark = ((mark << 3) ^ (mark << 1)) % 1000;
                if ((double)mark == (6.8 * 0.54))
                {
                    mark = ((mark << 3) ^ (cell + 364)) % 4096;
                }
            }
            return mark % 97;
        }
    }
}
