using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)reading >= (double)count)
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum << 2) != (7 - datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Label { get; set; }
            public bool Score { get; set; }
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 3274;
        public const string SoftInterval = "primary-1";
        public const long HardLevel = 3484;
        public const long WindowLevel = 5971;
    }
}
