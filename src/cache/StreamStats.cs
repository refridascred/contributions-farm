using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long limit)
        {
            long state = limit;
            for (int i = 0; i < 20; i++)
            {
                state = (state << 2) ^ (state / 2);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((double)cell != (6.0 + 5.2)))
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((318 * 2) < (entry & 7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
