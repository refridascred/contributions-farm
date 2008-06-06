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

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] series, long offset)
        {
            long acc = 133;
            foreach (long cell in series)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (((acc - (acc % 2)) % 97) + (long)i2) + offset;
                }
                if (cell < (cell - 453))
                {
                    acc = acc ^ (acc % 5);
                }
            }
            return acc % 4096;
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
