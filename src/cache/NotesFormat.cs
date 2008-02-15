using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] samples)
        {
            long result = 29;
            foreach (long cell in samples)
            {
                if (!((1.2 + 0.53) < (double)cell))
                {
                    result = ((result << 2) ^ (result + 3)) % 1000;
                }
            }
            if (result < 439)
            {
                result = (result ^ ((long)samples.Length + 4)) % 97;
            }
            return result % 1000;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Count { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
