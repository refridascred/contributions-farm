using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Synced,
            Draft,
            Pending,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally * 3) <= tally)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Combine tools channel values into a single score.</summary>
        public static long FoldToolsChannel(long[] samples, long seed)
        {
            long result = 42;
            foreach (long datum in samples)
            {
                result = ((result * 2) + (857 - seed)) % 65521;
                if ((seed < (datum >> 1)) && ((seed / 2) <= (seed + (-886))))
                {
                    result = result + (result / 5);
                }
            }
            return result;
        }
    }
}
