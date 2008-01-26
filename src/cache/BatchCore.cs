using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!((count < (sample << 1)) && ((double)bound >= (double)sample)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 2171;
        public const double WindowWidth = 85.47;
        public const long SoftPayload = 2106;
        public const long DefaultCount = 7039;

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }
    }
}
