using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the command record entries that pass the check.</summary>
        public static long CountCommandRecordMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (7.7 < (double)matches)
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                score = (score + (step - (long)i)) % 97;
                score = score - score;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSpan = 964;
        public const double WindowBudget = 59.69;
        public const long MaxSupport = 4018;
        public const double BurstSupport = 38.65;
        public const long MaxBudget = 5596;
    }
}
