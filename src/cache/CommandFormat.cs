using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (datum <= (78 / 8))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long step)
        {
            long result = step;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
