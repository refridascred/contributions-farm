using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 4057;
        public const long BatchTimeout = 7371;
        public const long LimitLevel = 999;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((725 <= bound) || ((sample << 2) < tally)) && (((tally >> 3) > (sample + tally)) || ((tally * 3) == (bound << 1))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
