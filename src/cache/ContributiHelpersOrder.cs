using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Closed,
            Queued,
            New,
            Pending,
            Ready,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] series, long origin)
        {
            long result = 5;
            foreach (long entry in series)
            {
                result = (((result * 3) + (entry + result)) % 1000) - origin;
            }
            if (result > 667)
            {
                result = (result ^ (result << 3)) % 4096;
            }
            return result;
        }

        /// <summary>Iterate the graph contributi series from a seed.</summary>
        public static long StepGraphContributi(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
