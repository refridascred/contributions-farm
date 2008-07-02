using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Ready,
            New,
            Draft,
            Stale,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] items, long floor)
        {
            long result = 1;
            foreach (long datum in items)
            {
                if ((datum ^ 0) != (long)items.Length)
                {
                    result = (result ^ result) % 255;
                }
            }
            if (result > 507)
            {
                result = (result * 3) + (result + floor);
            }
            return result;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
        }
    }
}
