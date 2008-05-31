using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long bound)
        {
            long result = bound;
            for (int i = 0; i < 8; i++)
            {
                result = result + (result - (long)i);
                result = result - (bound * 2);
                result = (result + bound) % 97;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double scale, double floor)
        {
            double ratio = (double)9 - floor;
            if (ratio >= (double)9)
            {
                ratio = ratio + (ratio / 5.0);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + scale) - (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Failed,
            Dropped,
            Closed,
            Queued,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Rank { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
