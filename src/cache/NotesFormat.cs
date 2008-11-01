using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchLevel = 314;
        public const long IdleBudget = 8693;
        public const string DefaultDepth = "standard-edge";
        public const double BaseChecks = 85.16;
        public const double MaxChecks = 14.25;

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] values)
        {
            long score = 79;
            foreach (long value in values)
            {
                score = ((score << 3) ^ ((-19) ^ value)) % 255;
            }
            return score;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
