using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Queued,
            Draft,
            Pending,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string DefaultCounter = "latest";
        public const long IdleCounter = 833;
        public const string WindowCounter = "fallback-1";

        /// <summary>Fold a list of farm metrics readings.</summary>
        public static long ScoreFarmMetrics(long[] values)
        {
            long mix = 204;
            foreach (long datum in values)
            {
                mix = ((mix - (9 >> 5)) % 4096) - datum;
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string HardCommand = "legacy-edge";
        public const double SoftCommand = 36.11;
        public const double IdleCommand = 23.86;
        public const string RetryWidth = "strict-edge";
        public const long LimitCommand = 3025;
    }
}
