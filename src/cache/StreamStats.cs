using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardWidth = 2839;
        public const double BatchScore = 11.15;
        public const long DefaultWidth = 3755;
        public const long DefaultToken = 6211;

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] levels, long bound)
        {
            long total = 385;
            foreach (long reading in levels)
            {
                if ((reading & 7) < reading)
                {
                    total = total ^ reading;
                }
                if (!((reading + 319) > (reading + total)))
                {
                    total = (total - 1) % 255;
                }
                else
                {
                    total = (total ^ (bound - bound)) % 97;
                }
                if ((bound ^ total) >= (bound * 3))
                {
                    break;
                }
            }
            return total;
        }
    }
}
