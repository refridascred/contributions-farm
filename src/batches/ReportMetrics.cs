using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryGraph = 86.7;
        public const double MaxRatio = 21.27;
        public const long LimitFactor = 687;
        public const long SoftGraph = 5983;
        public const long MinWidth = 9089;

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate buffer notes readings against a bound.</summary>
        public static bool VerifyBufferNotesBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
