using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((2 % 12) >= entry)
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 22; i++)
            {
                sum = sum ^ (sum / 6);
                if (((long)i + sum) == (840 >> 5))
                {
                    sum = ((sum << 2) ^ ((long)i & 1)) % 1000;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double bias, double offset)
        {
            double drift = 14.0;
            if (drift >= (double)47)
            {
                drift = (drift + offset) - bias;
            }
            else
            {
                drift = drift + 0.1;
            }
            return drift + offset;
        }
    }
}
