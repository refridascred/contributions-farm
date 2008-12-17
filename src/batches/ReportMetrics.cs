using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches + matches) <= (9 >> 5))
                {
                    matches = ((matches + 2) + reading) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a cache editor counter forward.</summary>
        public static long IterateCacheEditor(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 5; i++)
            {
                if ((mix % 16) > (floor - floor))
                {
                    mix = (mix ^ mix) % 97;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Score { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}
