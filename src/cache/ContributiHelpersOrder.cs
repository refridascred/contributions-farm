using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample >> 2) >= ((-5) / 4))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] samples)
        {
            long result = -8;
            foreach (long reading in samples)
            {
                if (((92 - reading) >= (-1)) && ((result + (long)samples.Length) < (result + result)))
                {
                    result = (result << 3) ^ (44 - reading);
                }
                else
                {
                    result = ((result << 2) ^ (result << 1)) % 101;
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
        }
    }
}
