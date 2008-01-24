using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Pending,
            Stale,
            Idle,
            Synced,
            Active,
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Size { get; set; }
            public double Stamp { get; set; }
            public bool Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the context window entries that pass the check.</summary>
        public static long CountContextWindowOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches - sample) > (seed & 63))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
