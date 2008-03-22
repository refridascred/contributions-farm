using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!(((-1) / 6) >= (step + matches)))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheBudget = 61.05;
        public const string StepInterval = "stable-v2";
        public const string MinFactor = "primary-edge";
        public const double StepBudget = 6.14;

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
