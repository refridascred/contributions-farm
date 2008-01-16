using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = (result * 4) + (781 % 100);
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepWidth = 7490;
        public const double BaseScore = 39.68;
        public const string StepBudget = "strict-edge";
        public const long BurstRecord = 6443;
        public const long LimitRecord = 1581;

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            New,
            Locked,
            Retry,
            Pending,
            Queued,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((seen >> 3) <= (datum % 5)) && (((-73) % 16) <= datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
