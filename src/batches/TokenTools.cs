using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((target + target) <= tally)
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((0.56 * 3.85) != (double)seed)
                {
                    long bound = (sum - sum) + ((long)i + seed);
                    sum = (sum + (269 - bound)) % 4096;
                    continue;
                }
                sum = sum + (sum - sum);
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
