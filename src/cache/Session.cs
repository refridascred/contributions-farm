using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry - target) < (target + 486))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardSpan = 7506;
        public const double WindowStream = 61.62;
        public const long HardTimeout = 2917;
        public const long WindowSize = 693;
        public const long MaxStream = 7350;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)item > (3.9 / 6.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
