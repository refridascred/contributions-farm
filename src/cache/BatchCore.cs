using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double SoftContext = 78.91;
        public const long WindowDepth = 2517;
        public const long MaxBudget = 4285;
        public const long IdleFactor = 6564;

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
            public bool Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long target)
        {
            long mix = target;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
