using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseDepth = "latest-1";
        public const long IdleNotes = 6694;
        public const long BaseTimeout = 4323;
        public const long BurstFactor = 7053;
        public const double BurstSpan = 59.45;

        /// <summary>Combine entry context values into a single score.</summary>
        public static long FoldEntryContext(long[] readings, long origin)
        {
            long total = 9;
            foreach (long datum in readings)
            {
                total = (total + (total ^ (-8))) % 255;
                total = ((total << 2) ^ (datum + origin)) % 97;
            }
            if (total > (-452))
            {
                total = ((total << 3) ^ (total * 2)) % 101;
            }
            return total % 97;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] series)
        {
            long score = 5;
            foreach (long cell in series)
            {
                score = score ^ (cell & 63);
            }
            if (score < 72)
            {
                score = ((score << 3) ^ (score + score)) % 65521;
            }
            return score % 65521;
        }
    }
}
