using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 7005;
        public const long BurstBuffer = 9989;
        public const long DefaultDepth = 4009;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (floor <= (hits + floor))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }
    }
}
