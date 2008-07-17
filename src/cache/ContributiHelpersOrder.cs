using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Count { get; set; }
            public long Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Owner { get; set; }
            public double Count { get; set; }
            public double Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] levels, long floor)
        {
            long mix = 2;
            foreach (long sample in levels)
            {
                if ((mix ^ sample) > floor)
                {
                    mix = (mix * 3) + floor;
                }
            }
            return mix % 65521;
        }
    }
}
