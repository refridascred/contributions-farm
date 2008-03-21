using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit notes account readings against a rule.</summary>
        public static long AuditNotesAccountMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value - count) <= (value / 4))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstInterval = 4243;
        public const string SoftFilter = "standard-v2";
        public const long DefaultInterval = 5568;
        public const double BaseFilter = 29.34;
        public const long DefaultFilter = 6734;
    }
}
