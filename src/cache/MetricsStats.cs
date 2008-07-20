using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Limit { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Synced,
            New,
            Draft,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long limit, long origin)
        {
            if ((6.0 + 3.14) < (double)limit)
            {
                return 8;
            }
            else
            {
                if (limit <= (origin ^ 8))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
