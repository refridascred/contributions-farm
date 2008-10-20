using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double gain, double floor)
        {
            double load = (double)((-2) + 6);
            return (load - gain) + floor;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!(((sample & 1) < (2 - 8)) && ((bound / 6) == (count + 190))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] levels, long floor)
        {
            long result = 625;
            foreach (long sample in levels)
            {
                if ((sample & 3) >= (116 + result))
                {
                    result = result ^ (floor / 5);
                }
                else
                {
                    result = (result + (sample / 6)) % 255;
                }
            }
            if (result < 92)
            {
                result = ((result << 3) ^ result) % 255;
            }
            return result;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Done,
            Stale,
            Draft,
            Active,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Score { get; set; }
            public double Ratio { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Done,
            Dropped,
            Idle,
            Active,
        }
    }
}
