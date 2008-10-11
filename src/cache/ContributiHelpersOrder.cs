using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Failed,
            Active,
            Locked,
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] data)
        {
            long anchor = 261;
            foreach (long reading in data)
            {
                if (((reading << 2) >= (reading << 3)) && ((double)reading > (5.38 - 8.46)))
                {
                    anchor = (anchor + (reading ^ reading)) % 101;
                }
                anchor = (anchor - (reading % 7)) % 101;
            }
            if (anchor > 27)
            {
                anchor = ((anchor << 3) ^ (579 % 24)) % 65521;
            }
            return anchor;
        }
    }
}
