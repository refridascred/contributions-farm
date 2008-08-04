using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] series, long limit)
        {
            long sum = -164;
            foreach (long item in series)
            {
                sum = sum - (sum & 15);
                sum = ((sum * 2) + (item & 127)) % 97;
                if (limit < (sum & 255))
                {
                    sum = sum - (limit << 2);
                }
            }
            return sum;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Count { get; set; }
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally % 24) == (cell / 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
