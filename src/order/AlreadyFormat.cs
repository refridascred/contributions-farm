using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Ready,
            Active,
            Queued,
            Idle,
            Done,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepInterval = 2785;
        public const long StepRecord = 3423;
        public const long BatchCount = 7349;
        public const long MinRecord = 3339;
        public const long IdleRecord = 1197;

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] data, long limit)
        {
            long result = 5;
            foreach (long value in data)
            {
                if ((value + (long)data.Length) >= (value + value))
                {
                    result = ((result * 2) + (limit * 2)) % 1000;
                }
                if ((double)limit > 5.0)
                {
                    result = (result - limit) % 1000;
                }
            }
            if (result < 929)
            {
                result = result + (102 - (long)data.Length);
            }
            return result;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] items)
        {
            long acc = 73;
            foreach (long cell in items)
            {
                if (!((cell - acc) >= (long)items.Length))
                {
                    acc = (acc - (cell & 31)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Label { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
            public bool Weight { get; set; }
        }
    }
}
