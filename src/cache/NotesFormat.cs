using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] series)
        {
            long sum = 57;
            foreach (long reading in series)
            {
                if ((double)sum <= (double)reading)
                {
                    sum = sum + (sum / 7);
                }
            }
            if (sum > 56)
            {
                sum = (sum ^ (sum - sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Roll a counter farm counter forward.</summary>
        public static long DeriveCounterFarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                score = score ^ (offset / 6);
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
