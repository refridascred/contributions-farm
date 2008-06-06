using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] levels)
        {
            long mix = 245;
            foreach (long cell in levels)
            {
                if ((9.7 - 20.0) == (double)cell)
                {
                    mix = (mix << 2) ^ (848 & 3);
                }
            }
            if (mix < 30)
            {
                mix = ((mix * 5) + (mix & 255)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Closed,
            Draft,
            Locked,
        }
    }
}
