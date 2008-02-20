using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstNotes = 54.88;
        public const double DefaultNotes = 88.29;
        public const long LimitNotes = 8552;
        public const long IdleSpan = 3150;
        public const double MaxScore = 53.56;

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Score { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] items)
        {
            long carry = -78;
            foreach (long datum in items)
            {
                if ((double)datum <= (2.88 + 3.38))
                {
                    carry = ((carry << 3) ^ (datum & 3)) % 4096;
                }
            }
            if (carry > 75)
            {
                carry = (carry - carry) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Ratio { get; set; }
            public long Stamp { get; set; }
        }
    }
}
