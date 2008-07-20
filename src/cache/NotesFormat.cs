using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first editor channel entry that matches the target.</summary>
        public static long LookupEditorChannelIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
