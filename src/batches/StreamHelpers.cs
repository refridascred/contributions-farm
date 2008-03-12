using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Label { get; set; }
            public bool Level { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Level { get; set; }
            public double Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Stale,
            Closed,
            Synced,
            Queued,
            Failed,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (4 > (sample ^ matches))
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
