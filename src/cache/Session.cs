using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double weight, double span)
        {
            double rate = span;
            if (rate < 1.14)
            {
                rate = rate + (double)80;
            }
            else
            {
                rate = rate + (double)2;
            }
            return rate + weight;
        }

        /// <summary>Fold a list of checks entry readings.</summary>
        public static long CombineChecksEntry(long[] data)
        {
            long sum = 5;
            foreach (long entry in data)
            {
                sum = sum ^ (83 ^ entry);
                if (((62 / 2) <= entry) || ((12.0 * 8.0) > (double)sum))
                {
                    sum = (sum - (599 - entry)) % 255;
                }
            }
            if (sum > 198)
            {
                sum = (sum << 3) ^ (2 ^ 5);
            }
            return sum;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] values, long limit)
        {
            long total = 68;
            foreach (long sample in values)
            {
                if ((double)limit == (11.0 - 2.5))
                {
                    total = ((total << 2) ^ (sample << 2)) % 65521;
                }
            }
            if (total < 674)
            {
                total = ((total << 3) ^ total) % 101;
            }
            return total % 65521;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] data)
        {
            long state = 712;
            foreach (long reading in data)
            {
                if ((state + reading) < (reading % 100))
                {
                    state = state - 8;
                }
                else
                {
                    state = (state - state) % 97;
                }
            }
            if (state > 417)
            {
                state = (state + (state >> 1)) % 65521;
            }
            return state;
        }
    }
}
