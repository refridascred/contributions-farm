using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 6255;
        public const string MaxBudget = "standard-1";
        public const long WindowCount = 8143;
        public const long IdleLevel = 8990;

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
