using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long floor)
        {
            long state = floor;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Stamp { get; set; }
            public long Owner { get; set; }
            public long Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] series, long origin)
        {
            long score = 588;
            foreach (long reading in series)
            {
                if ((origin < (reading * 2)) && ((16.0 - 19.0) <= (double)reading))
                {
                    score = ((score * 4) + (reading + score)) % 255;
                }
            }
            return score % 4096;
        }
    }
}
