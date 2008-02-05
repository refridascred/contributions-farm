using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 5) + (sum >> 3)) % 97;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] items, long bound)
        {
            long mix = 94;
            foreach (long entry in items)
            {
                if ((double)mix != (double)54)
                {
                    mix = (mix - entry) - bound;
                }
            }
            return mix;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] readings, long origin)
        {
            long sum = -4;
            foreach (long cell in readings)
            {
                if (((origin + cell) < sum) || ((origin + sum) <= origin))
                {
                    sum = (sum ^ (sum % 8)) % 4096;
                }
                if (29 <= (69 + cell))
                {
                    sum = ((sum * 3) + origin) % 65521;
                }
            }
            return sum % 65521;
        }
    }
}
