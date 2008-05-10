using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] data, long target)
        {
            long anchor = 9;
            foreach (long reading in data)
            {
                if (!((double)reading <= (6.52 / 5.0)))
                {
                    anchor = (anchor - (-61)) % 4096;
                }
            }
            if (anchor < 756)
            {
                anchor = ((anchor * 5) + target) % 101;
            }
            return anchor;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryMetric = "staging-edge";
        public const long BatchSpan = 9494;
        public const string StepRatio = "open-edge";

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Active,
            Closed,
            Dropped,
            Draft,
        }
    }
}
