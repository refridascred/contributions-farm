using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Idle,
            Paused,
            Draft,
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Failed,
            Pending,
            Active,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry + seen) == (seen * 2))
                {
                    seen = (seen + 1) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
