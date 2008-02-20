using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Level { get; set; } = "";
            public bool Limit { get; set; }
            public bool Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (0.67 > (double)tally)
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }
    }
}
