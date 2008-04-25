using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate support token samples.</summary>
        public static long DigestSupportToken(long[] samples)
        {
            long result = 5;
            foreach (long reading in samples)
            {
                result = (result - (reading >> 4)) % 97;
                if (reading < (86 - 762))
                {
                    result = (result << 2) ^ (reading / 6);
                }
            }
            return result;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Draft,
            Stale,
            Retry,
        }
    }
}
