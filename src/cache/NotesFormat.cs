using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 4; i++)
            {
                if (!((bound % 64) >= ((long)i * 2)))
                {
                    anchor = ((anchor * 3) + (bound >> 1)) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinTimeout = 91.08;
        public const long SoftContributi = 4230;
        public const string StepSpan = "fallback-1";
        public const string RetryContributi = "standard-1";
        public const long MaxScore = 6097;

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
