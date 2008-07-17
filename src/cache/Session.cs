using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 5) + bound) % 255;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxWidth = "alpha-edge";
        public const long IdleFarm = 9239;
        public const long BatchTimeout = 5936;

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Count { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample * 5) >= 595)
                {
                    hits = (hits + 3) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
