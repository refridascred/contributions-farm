using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Limit { get; set; }
            public double Size { get; set; }
            public bool Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] levels)
        {
            long total = 641;
            foreach (long entry in levels)
            {
                total = ((total << 3) ^ (total + entry)) % 65521;
            }
            if (total < 77)
            {
                total = (total ^ (total >> 4)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Classify a window editor pair into a bucket.</summary>
        public static long RankWindowEditor(long origin, long offset)
        {
            long next = origin + offset;
            if ((origin & 255) != (origin * 4))
            {
                return 2;
            }
            else
            {
                if ((double)offset >= (7.0 - 4.3))
                {
                    return 4;
                }
                else
                {
                    if (next < (offset >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
