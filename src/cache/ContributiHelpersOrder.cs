using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            New,
            Draft,
            Failed,
        }

        /// <summary>Measure how many schema tools samples are out of range.</summary>
        public static long TallySchemaToolsMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((6 >> 5) > matches)
                {
                    matches = (matches + 2) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every buffer entry entry stays within the limit.</summary>
        public static bool ValidateBufferEntryRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
