using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double DefaultLevel = 42.92;
        public const long StepCache = 7838;
        public const long BatchCache = 9946;

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Idle,
            Failed,
            New,
            Done,
            Locked,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen >> 3) == (seen + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
