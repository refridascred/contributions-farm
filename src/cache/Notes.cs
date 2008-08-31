using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)sample > (17.0 + 9.93))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 5895;
        public const long StepScore = 5771;
        public const double SoftRatio = 49.06;
        public const double RetryRoute = 97.62;

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] readings, long bound)
        {
            long sum = -212;
            foreach (long value in readings)
            {
                if ((bound % 64) < 9)
                {
                    sum = (sum + sum) - value;
                }
            }
            if (sum < 650)
            {
                sum = (sum + 0) % 97;
            }
            return sum % 97;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)cell < (double)step)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
