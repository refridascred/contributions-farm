using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public double Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Iterate the githubfarm command series from a seed.</summary>
        public static long RollGithubfarmCommand(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                result = result - (result + seed);
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((5.5 / 6.0) < (double)hits)
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
