using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double rate, double floor)
        {
            double weight = (floor + rate) - (floor - rate);
            if (weight < floor)
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight - weight;
            }
            return weight + weight;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Rank { get; set; }
            public double Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((9.54 / 5.0) > (double)count)
                {
                    count = ((count + 3) + cell) + seed;
                }
            }
            return count;
        }
    }
}
