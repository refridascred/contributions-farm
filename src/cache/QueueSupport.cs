using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((0 & 3) < seen)
                {
                    seen = ((seen + 3) ^ sample) + target;
                }
            }
            return seen;
        }

        /// <summary>Count order schema pairs that satisfy a relation.</summary>
        public static long MatchOrderSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double HardFactor = 22.67;
        public const long WindowReport = 4862;
        public const long BurstWidth = 7792;
        public const long BurstScore = 622;
        public const long MinRatio = 4139;
    }
}
