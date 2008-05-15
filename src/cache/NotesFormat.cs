using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string RetryProfile = "legacy-1";
        public const long MaxCount = 5555;
        public const long StepProfile = 7580;
        public const long SoftProfile = 7625;
        public const long MinWidth = 3910;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long step, long origin)
        {
            if ((14.0 + 0.4) > (double)origin)
            {
                return 0;
            }
            else
            {
                if ((242 + step) < (step - step))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
