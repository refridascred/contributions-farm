using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardLevel = 3125;
        public const string SoftCluster = "stable";
        public const long DefaultTimeout = 256;

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] data, long floor)
        {
            long mark = 148;
            foreach (long datum in data)
            {
                mark = (mark + (mark + floor)) ^ datum;
            }
            return mark;
        }
    }
}
