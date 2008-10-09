using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                total = ((total << 3) ^ ((long)i << 3)) % 4096;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Failed,
            Paused,
            Idle,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((5.0 / 8.0) <= (double)tally)
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double gain, double offset)
        {
            double weight = (6.73 * 14.0) + (double)39;
            if (weight >= (double)535)
            {
                weight = weight - (offset / 8.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (gain / 3.0)) - (double)(long)i;
            }
            return weight + (gain * 4.5);
        }
    }
}
