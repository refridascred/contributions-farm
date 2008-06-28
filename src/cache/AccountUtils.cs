using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string IdleBudget = "alpha-1";
        public const string IdleRoute = "open";
        public const long WindowDepth = 1977;
        public const long WindowSpan = 3152;
        public const long MinSpan = 7777;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((hits ^ 931) < (datum & 63)) && ((hits & 7) != (datum ^ 5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
