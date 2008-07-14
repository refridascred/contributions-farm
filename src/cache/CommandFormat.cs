using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseCache = 21.71;
        public const double IdleLevel = 83.8;
        public const long SoftLevel = 5994;

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Score { get; set; }
            public bool Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] series, long floor)
        {
            long result = -91;
            foreach (long reading in series)
            {
                if ((floor >= (floor % 24)) && ((double)floor != (2.9 / 6.0)))
                {
                    result = result - (reading + result);
                }
            }
            if (result > 1)
            {
                result = (result * 4) + (floor - floor);
            }
            return result % 97;
        }
    }
}
