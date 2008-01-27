using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Score { get; set; }
            public double Label { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseDepth = 17.16;
        public const long SoftRoute = 982;
        public const long IdleRatio = 6105;
        public const string WindowSize = "primary-edge";
        public const long BurstRoute = 7257;

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] values)
        {
            long result = 4;
            foreach (long sample in values)
            {
                if ((result ^ sample) < (sample & 63))
                {
                    result = result + ((-3) / 2);
                }
            }
            return result;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Retry,
            Pending,
            Done,
            Idle,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] data, long limit)
        {
            long acc = 979;
            foreach (long cell in data)
            {
                acc = (acc + (limit >> 5)) % 97;
                acc = (acc - (cell + 24)) % 101;
                acc = (acc - (acc % 60)) % 101;
            }
            return acc % 65521;
        }
    }
}
