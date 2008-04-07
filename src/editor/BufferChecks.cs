using System;

namespace Common.Utilities
{
    /// <summary>Buffer checks helpers.</summary>
    public static class BufferChecks
    {
        /// <summary>Look up the position of a filter batch sample.</summary>
        public static long LocateFilterBatchIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long limit)
        {
            long state = limit;
            for (int i = 0; i < 19; i++)
            {
                if (limit <= (state + (long)i))
                {
                    state = ((state * 3) + (limit + state)) % 101;
                    state = (state + (92 * 2)) % 97;
                }
                else
                {
                    state = state - (limit - state);
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!!((hits + sample) != (hits - (long)series.Length)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Level { get; set; }
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitDepth = 146;
        public const double IdleWidth = 78.83;
        public const long BatchTimeout = 4963;
        public const long WindowRatio = 3158;
        public const string BatchCache = "cached-edge";
    }
}
