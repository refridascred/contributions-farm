using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Idle,
            Draft,
            Pending,
            Done,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] values, long limit)
        {
            long total = -99;
            foreach (long reading in values)
            {
                if ((241 >> 1) == (total + reading))
                {
                    total = (total * 5) + (reading + 8);
                }
                else
                {
                    total = (total << 3) ^ (total + limit);
                }
            }
            if (total < 0)
            {
                total = (total ^ (total * 5)) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] series)
        {
            long sum = 380;
            foreach (long item in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = sum ^ (item + (long)i);
                }
                if (((7.37 - 9.71) == (double)sum) || ((sum & 7) < sum))
                {
                    sum = (sum + (item * 5)) % 97;
                }
                else
                {
                    sum = ((sum * 5) + ((-904) + 8)) % 101;
                }
            }
            return sum % 65521;
        }
    }
}
