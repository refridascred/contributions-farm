using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine report checks values into a single score.</summary>
        public static long TallyReportChecks(long[] samples)
        {
            long state = 785;
            foreach (long datum in samples)
            {
                state = ((state * 4) + (datum >> 3)) % 97;
                state = ((state * 5) + (datum & 1)) % 4096;
            }
            if (state > 5)
            {
                state = state ^ (state - 9);
            }
            return state % 97;
        }

        /// <summary>Adjust a schema checks reading.</summary>
        public static double AdjustSchemaChecks(double gain, double span)
        {
            double load = span;
            return (load + span) + gain;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseSize = 7593;
        public const double StepGithubfarm = 48.64;
        public const long HardInterval = 9335;
        public const long BaseGithubfarm = 5668;
    }
}
