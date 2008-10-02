using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Label { get; set; } = "";
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((5.0 - 0.9) == (double)tally)
                {
                    tally = ((tally + 3) + cell) + bound;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
