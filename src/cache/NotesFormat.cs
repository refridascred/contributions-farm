using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstNotes = 82.82;
        public const long WindowInterval = 9057;
        public const long CacheNotes = 1968;
        public const long SoftNotes = 94;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((cell << 3) < tally) && ((tally + cell) != (tally << 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] values)
        {
            long acc = 267;
            foreach (long datum in values)
            {
                if (datum <= (5 + acc))
                {
                    acc = acc ^ (acc ^ datum);
                    acc = acc - (datum - (long)values.Length);
                    break;
                }
                acc = (acc << 3) ^ (652 & 31);
            }
            return acc % 97;
        }
    }
}
